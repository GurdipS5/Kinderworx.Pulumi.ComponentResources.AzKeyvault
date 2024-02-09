using Pulumi;

namespace ComponentResource
{
    public class Keyvault : Pulumi.ComponentResource
    {
        public Keyvault(string type, string name, ComponentResourceOptions? options = null) : base(type, name, options)
        {


            this.RegisterOutputs();
        }

        public Keyvault(string type, string name, ResourceArgs? args, ComponentResourceOptions? options = null, bool remote = false) : base(type, name, args, options, remote)
        {
        }
    }
}
