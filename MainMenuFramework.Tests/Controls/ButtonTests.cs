using MainMenuFramework.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Moq;
using NUnit.Framework;

namespace MainMenuFramework.Tests.Controls
{
    [TestFixture]
    public class ButtonTests
    {
        [Test]
        public void TestMethod1()
        {
            var textureMock = Mock.Of<Texture2D>();
            var button = new Button(textureMock, new Vector2(200, 200),
                new Text(Mock.Of<SpriteFont>(), "Test Text", new Vector2(200, 200)));
        }
    }
}
