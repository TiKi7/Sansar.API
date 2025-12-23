using Sansar;
using Sansar.Script;
using Sansar.Simulation;

namespace Context7
{
    [RegisterComponent]
    public class StarterScript : SceneObjectScript
    {
        public override void Init()
        {
            Log.Write("Context7 Service Initialized.");
        }
    }
}
