﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Graphics;
using SiliconStudio.Paradox.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Paradox.Graphics.Buffer;

using SiliconStudio.Paradox.Effects.Data;
namespace ParadoxCraft.Effects
{
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxCraftPrepassEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ParadoxDefaultLightPrepassEffect");
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ParadoxCraftPrepassEffect", new ParadoxCraftPrepassEffect());
            }
        }
    }
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxCraftEffectMain  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ParadoxDefaultDeferredShader");
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ParadoxCraftEffectMain", new ParadoxCraftEffectMain());
            }
        }
    }
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxCraftEffectForward  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ParadoxDefaultForwardShader");
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ParadoxCraftEffectForward", new ParadoxCraftEffectForward());
            }
        }
    }
}
