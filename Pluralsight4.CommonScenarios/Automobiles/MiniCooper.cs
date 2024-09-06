
namespace Automobiles
{
    public class MiniCooper : IAutomobile
    {
        public string Name { get; } = "Mini Cooper";

        public string Start()
        {
            return "VRoooom!";
        }

        public string Stop()
        {
            return "Screech!";
        }
    }
}