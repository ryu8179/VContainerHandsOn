using VContainer;
using VContainer.Unity;

namespace MyGame
{
    public class GamePresenter : IStartable, ITickable
    {
        readonly HelloWorldService helloWorldService;
        readonly HelloScreen helloScreen;

        public GamePresenter(
            HelloWorldService helloWorldService,
            HelloScreen helloScreen)
        {
            this.helloWorldService = helloWorldService;
            this.helloScreen = helloScreen;
        }

        public void Start()
        {
            helloScreen.HelloButton.onClick.AddListener(() =>
            {
                helloWorldService.Hello2();
            });
        }

        public void Tick()
        {
            helloWorldService.Hello();
        }
    }
}
