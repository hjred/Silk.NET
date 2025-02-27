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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_fence")]
    public unsafe partial class NVFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fence";
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public unsafe partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint fences);

        [NativeApi(EntryPoint = "glFinishFenceNV")]
        public partial void FinishFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGenFencesNV")]
        public unsafe partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGenFencesNV")]
        public partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint fences);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public unsafe partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public unsafe partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFenceNV")]
        public partial bool IsFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceNV")]
        public partial void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV condition);

        [NativeApi(EntryPoint = "glSetFenceNV")]
        public partial void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceConditionNV condition);

        [NativeApi(EntryPoint = "glTestFenceNV")]
        public partial bool TestFence([Flow(FlowDirection.In)] uint fence);

        public unsafe void DeleteFence([Count(Parameter = "n"), Flow(FlowDirection.In)] uint fences)
        {
            // ArrayParameterOverloader
            DeleteFences(1, &fences);
        }

        public unsafe uint GenFence()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFences(n, &ret);
            return ret;
        }

        public NVFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

