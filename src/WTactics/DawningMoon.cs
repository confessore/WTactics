using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using WTactics.Enums;
using WTactics.Models;
using WTactics.Services.Interfaces;
using WTactics.Statics;

namespace WTactics
{
    public sealed class DawningMoon : Game
    {
        readonly IContentService contentService;
        readonly IMenuService menuService;
        readonly ITileService tileService;
        readonly IMapService mapService;
        readonly IRegistrationService registrationService;

        public DawningMoon(
            IContentService contentService,
            IMenuService menuService,
            ITileService tileService,
            IMapService mapService,
            IRegistrationService registrationService)
        {
            this.contentService = contentService;
            this.menuService = menuService;
            this.tileService = tileService;
            this.mapService = mapService;
            this.registrationService = registrationService;
            GraphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            GraphicsDeviceManager.PreferredBackBufferHeight = WindowDimensions.height;
            GraphicsDeviceManager.PreferredBackBufferWidth = WindowDimensions.width;
            TransformMatrix = Matrix.CreateScale(zoom);
            GameState = GameState.Menu;
        }

        (int width, int height) WindowDimensions => (width: 1024, height: 768);
        const int zoom = 1;
        GraphicsDeviceManager GraphicsDeviceManager { get; set; }
        SpriteBatch SpriteBatch { get; set; }

        public static Matrix TransformMatrix { get; set; } = new Matrix();
        public static GameState GameState { get; set; }
        public static Camera Camera { get; set; }
        public static Menu Menu { get; set; }
        public static Map Map { get; set; }

        protected override async void Initialize()
        {
            await registrationService.InitializeAsync();
            TextureDictionaries.MenuTextures = await contentService.LoadMenuTexturesAsync(Content);
            TextureDictionaries.GMenuTextures = await contentService.LoadGMenuTexturesAsync(Content);
            TextureDictionaries.TerrainTextures = await contentService.LoadTerrainTexturesAsync(Content);
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            Camera = new Camera(SpriteBatch);
            Menu = await menuService.GenerateNewMenuAsync();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override async void Update(GameTime gameTime)
        {
            Map = await mapService.GenerateNewMapAsync();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);
            SpriteBatch.Begin(
                sortMode: SpriteSortMode.Immediate,
                samplerState: SamplerState.PointClamp,
                transformMatrix: Camera.Transform(GraphicsDevice, WindowDimensions));
            switch (GameState)
            {
                case GameState.Menu:
                    foreach (var menuItem in Menu.MenuItems)
                        menuItem.Draw64x16(SpriteBatch);
                    break;
                case GameState.DawningMoon:
                    foreach (var tile in Map.Tiles)
                        tile.Draw16x16(SpriteBatch);
                    break;
                default:
                    break;
            }
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
