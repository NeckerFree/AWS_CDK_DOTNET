using Amazon.CDK;
using Amazon.CDK.AWS.S3;
using Constructs;

namespace Kit
{
    public class KitStack : Stack
    {
        internal KitStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var bucket = new Bucket(this, "HelloWorldBucket", new BucketProps
            {
                Versioned = true, // Enable versioning on the bucket
            });
        }
    }
}
