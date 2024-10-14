using Amazon.CDK;
using Constructs;

namespace Kit
{
    public class KitStack : Stack
    {
        internal KitStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // The code that defines your stack goes here
        }
    }
}
