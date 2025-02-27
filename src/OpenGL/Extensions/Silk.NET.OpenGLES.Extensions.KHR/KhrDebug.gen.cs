// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.KHR
{
    [Extension("KHR_debug")]
    public unsafe partial class KhrDebug : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_debug";
        [NativeApi(EntryPoint = "glDebugMessageCallbackKHR")]
        public unsafe partial void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcKhr callback, [Flow(FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallbackKHR")]
        public partial void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcKhr callback, [Flow(FlowDirection.In)] in T0 userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlKHR")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertKHR")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out KHR severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogKHR")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetObjectLabelKHR")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabelKHR")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabelKHR")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabelKHR")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabelKHR")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabelKHR")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabelKHR")]
        public partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPointervKHR")]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] KHR pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointervKHR")]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] KHR pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glObjectLabelKHR")]
        public unsafe partial void ObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectLabelKHR")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glObjectLabelKHR")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectLabelKHR")]
        public unsafe partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectLabelKHR")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glObjectLabelKHR")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabelKHR")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectPtrLabelKHR")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glObjectPtrLabelKHR")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabelKHR")]
        public unsafe partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectPtrLabelKHR")]
        public partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectPtrLabelKHR")]
        public partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPopDebugGroupKHR")]
        public partial void PopDebugGroup();

        [NativeApi(EntryPoint = "glPushDebugGroupKHR")]
        public unsafe partial void PushDebugGroup([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glPushDebugGroupKHR")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte message);

        [NativeApi(EntryPoint = "glPushDebugGroupKHR")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        [NativeApi(EntryPoint = "glPushDebugGroupKHR")]
        public unsafe partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glPushDebugGroupKHR")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte message);

        [NativeApi(EntryPoint = "glPushDebugGroupKHR")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        public unsafe void* GetPointer([Flow(FlowDirection.In)] KHR pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public KhrDebug(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

