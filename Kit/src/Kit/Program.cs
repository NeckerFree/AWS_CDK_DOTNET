using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kit
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new KitStack(app, "KitStack", new StackProps
            {

            });
            app.Synth();
        }
    }
}