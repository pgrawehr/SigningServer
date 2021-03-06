﻿using SigningServer.Contracts;
using SigningServer.Server.PE;
using SigningServer.Server.SigningTool;

namespace SigningServer.Server
{
    public class DefaultSigningToolProvider : EnumerableSigningToolProvider
    {
        private static readonly ISigningTool[] SigningTools =
        {
            new PortableExectuableSigningTool(),
            new AndroidApkSigningTool()
        };

        public DefaultSigningToolProvider()
            : base(SigningTools)
        {
            
        }
    }
}