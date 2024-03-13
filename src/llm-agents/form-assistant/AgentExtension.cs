﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGen.Core;

namespace FormAssistant;

internal static class AgentExtension
{
    public static MiddlewareAgent<TAgent> RegisterSpectreConsoleOutput<TAgent>(this TAgent agent)
        where TAgent : IAgent
    {
        var middleware = new SpectreOutputMiddleware();
        return agent.RegisterMiddleware(middleware);
    }
}