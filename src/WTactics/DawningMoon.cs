using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using WTactics.Models;
using WTactics.Services.Interfaces;
using WTactics.Statics;

namespace WTactics
{
    public sealed class DawningMoon : Game
    {
        readonly IContentService contentService;
        readonly ITileService tileService;
        readonly IMapService mapService;
        readonly IRegistrationService registrationService;

        public DawningMoon(
            IContentService contentService,
            ITileService tileService,
            IMapService mapService,
            IRegistrationService registrationService)
        {
            this.contentService = contentService;
            this.tileService = tileService;
            this.mapService = mapService;
            this.registrationService = registrationService;
            GraphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            GraphicsDeviceManager.PreferredBackBufferHeight = WindowDimensions.height;
            GraphicsDeviceManager.PreferredBackBufferWidth = WindowDimensions.width;
            TransformMatrix = Matrix.CreateScale(zoom);
        }

        (int width, int height) WindowDimensions => (width: 1024, height: 768);
        const int zoom = 1;
        GraphicsDeviceManager GraphicsDeviceManager { get; set; }
        SpriteBatch SpriteBatch { get; set; }

        public static Random Random { get; set; }
        public static Camera Camera { get; set; }
        public static Matrix TransformMatrix { get; set; } = new Matrix();
        public static Map Map { get; set; } = new Map();

        protected override async void Initialize()
        {
            await registrationService.InitializeAsync();
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            Camera = new Camera(SpriteBatch);
            TextureDictionaries.TerrainTextures = await contentService.LoadTerrainsAsync(Content);
            Map = await mapService.GenerateNewMapAsync();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);
            SpriteBatch.Begin(
                sortMode: SpriteSortMode.Immediate,
                samplerState: SamplerState.PointClamp,
                transformMatrix: Camera.Transform(GraphicsDevice, WindowDimensions));
            foreach (var tile in Map.Tiles)
                tile.Draw(SpriteBatch);
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
