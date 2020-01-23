// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

#if NETCOREAPP3_1
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Options;

namespace Microsoft.Bing.AspNetCore.Connections.InlineSocket
{
    public class KestrelServerOptionsDefaults : IConfigureOptions<KestrelServerOptions>
    {
        public void Configure(KestrelServerOptions options)
        {
            options.AllowSynchronousIO = true;
        }
    }
}
#endif
