//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version42
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002
        /// </summary>
        ElementArrayBarrierBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        /// </summary>
        TextureFetchBarrierBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT = 0x00000040
        /// </summary>
        CommandBarrierBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080
        /// </summary>
        PixelBufferBarrierBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        /// </summary>
        FramebufferBarrierBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = 0x8e23,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = 0x8e24,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = 0x8e8c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = 0x8e8d,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = 0x8e8e,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = 0x8e8f,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER_BINDING = 0x8F36
        /// </summary>
        CopyReadBufferBinding = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER_BINDING = 0x8F37
        /// </summary>
        CopyWriteBufferBinding = 0x8f37,

        /// <summary>
        /// Original was GL_MAX_IMAGE_UNITS = 0x8F38
        /// </summary>
        MaxImageUnits = 0x8f38,

        /// <summary>
        /// Original was GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39
        /// </summary>
        MaxCombinedImageUnitsAndFragmentOutputs = 0x8f39,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_NAME = 0x8F3A
        /// </summary>
        ImageBindingName = 0x8f3a,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LEVEL = 0x8F3B
        /// </summary>
        ImageBindingLevel = 0x8f3b,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LAYERED = 0x8F3C
        /// </summary>
        ImageBindingLayered = 0x8f3c,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LAYER = 0x8F3D
        /// </summary>
        ImageBindingLayer = 0x8f3d,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_ACCESS = 0x8F3E
        /// </summary>
        ImageBindingAccess = 0x8f3e,

        /// <summary>
        /// Original was GL_IMAGE_1D = 0x904C
        /// </summary>
        Image1D = 0x904c,

        /// <summary>
        /// Original was GL_IMAGE_2D = 0x904D
        /// </summary>
        Image2D = 0x904d,

        /// <summary>
        /// Original was GL_IMAGE_3D = 0x904E
        /// </summary>
        Image3D = 0x904e,

        /// <summary>
        /// Original was GL_IMAGE_2D_RECT = 0x904F
        /// </summary>
        Image2DRect = 0x904f,

        /// <summary>
        /// Original was GL_IMAGE_CUBE = 0x9050
        /// </summary>
        ImageCube = 0x9050,

        /// <summary>
        /// Original was GL_IMAGE_BUFFER = 0x9051
        /// </summary>
        ImageBuffer = 0x9051,

        /// <summary>
        /// Original was GL_IMAGE_1D_ARRAY = 0x9052
        /// </summary>
        Image1DArray = 0x9052,

        /// <summary>
        /// Original was GL_IMAGE_2D_ARRAY = 0x9053
        /// </summary>
        Image2DArray = 0x9053,

        /// <summary>
        /// Original was GL_IMAGE_CUBE_MAP_ARRAY = 0x9054
        /// </summary>
        ImageCubeMapArray = 0x9054,

        /// <summary>
        /// Original was GL_IMAGE_2D_MULTISAMPLE = 0x9055
        /// </summary>
        Image2DMultisample = 0x9055,

        /// <summary>
        /// Original was GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056
        /// </summary>
        Image2DMultisampleArray = 0x9056,

        /// <summary>
        /// Original was GL_INT_IMAGE_1D = 0x9057
        /// </summary>
        IntImage1D = 0x9057,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D = 0x9058
        /// </summary>
        IntImage2D = 0x9058,

        /// <summary>
        /// Original was GL_INT_IMAGE_3D = 0x9059
        /// </summary>
        IntImage3D = 0x9059,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_RECT = 0x905A
        /// </summary>
        IntImage2DRect = 0x905a,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE = 0x905B
        /// </summary>
        IntImageCube = 0x905b,

        /// <summary>
        /// Original was GL_INT_IMAGE_BUFFER = 0x905C
        /// </summary>
        IntImageBuffer = 0x905c,

        /// <summary>
        /// Original was GL_INT_IMAGE_1D_ARRAY = 0x905D
        /// </summary>
        IntImage1DArray = 0x905d,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_ARRAY = 0x905E
        /// </summary>
        IntImage2DArray = 0x905e,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F
        /// </summary>
        IntImageCubeMapArray = 0x905f,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060
        /// </summary>
        IntImage2DMultisample = 0x9060,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061
        /// </summary>
        IntImage2DMultisampleArray = 0x9061,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_1D = 0x9062
        /// </summary>
        UnsignedIntImage1D = 0x9062,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D = 0x9063
        /// </summary>
        UnsignedIntImage2D = 0x9063,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_3D = 0x9064
        /// </summary>
        UnsignedIntImage3D = 0x9064,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065
        /// </summary>
        UnsignedIntImage2DRect = 0x9065,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066
        /// </summary>
        UnsignedIntImageCube = 0x9066,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067
        /// </summary>
        UnsignedIntImageBuffer = 0x9067,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068
        /// </summary>
        UnsignedIntImage1DArray = 0x9068,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069
        /// </summary>
        UnsignedIntImage2DArray = 0x9069,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A
        /// </summary>
        UnsignedIntImageCubeMapArray = 0x906a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B
        /// </summary>
        UnsignedIntImage2DMultisample = 0x906b,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C
        /// </summary>
        UnsignedIntImage2DMultisampleArray = 0x906c,

        /// <summary>
        /// Original was GL_MAX_IMAGE_SAMPLES = 0x906D
        /// </summary>
        MaxImageSamples = 0x906d,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_FORMAT = 0x906E
        /// </summary>
        ImageBindingFormat = 0x906e,

        /// <summary>
        /// Original was GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC
        /// </summary>
        MinMapBufferAlignment = 0x90bc,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = 0x90c7,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8
        /// </summary>
        ImageFormatCompatibilityBySize = 0x90c8,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9
        /// </summary>
        ImageFormatCompatibilityByClass = 0x90c9,

        /// <summary>
        /// Original was GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA
        /// </summary>
        MaxVertexImageUniforms = 0x90ca,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB
        /// </summary>
        MaxTessControlImageUniforms = 0x90cb,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC
        /// </summary>
        MaxTessEvaluationImageUniforms = 0x90cc,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD
        /// </summary>
        MaxGeometryImageUniforms = 0x90cd,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE
        /// </summary>
        MaxFragmentImageUniforms = 0x90ce,

        /// <summary>
        /// Original was GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF
        /// </summary>
        MaxCombinedImageUniforms = 0x90cf,

        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127
        /// </summary>
        UnpackCompressedBlockWidth = 0x9127,

        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128
        /// </summary>
        UnpackCompressedBlockHeight = 0x9128,

        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129
        /// </summary>
        UnpackCompressedBlockDepth = 0x9129,

        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A
        /// </summary>
        UnpackCompressedBlockSize = 0x912a,

        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B
        /// </summary>
        PackCompressedBlockWidth = 0x912b,

        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C
        /// </summary>
        PackCompressedBlockHeight = 0x912c,

        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D
        /// </summary>
        PackCompressedBlockDepth = 0x912d,

        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E
        /// </summary>
        PackCompressedBlockSize = 0x912e,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        /// </summary>
        TextureImmutableFormat = 0x912f,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = 0x92c1,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2
        /// </summary>
        AtomicCounterBufferStart = 0x92c2,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3
        /// </summary>
        AtomicCounterBufferSize = 0x92c3,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        /// </summary>
        AtomicCounterBufferDataSize = 0x92c4,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        /// </summary>
        AtomicCounterBufferActiveAtomicCounters = 0x92c5,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        /// </summary>
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92c6,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        /// </summary>
        AtomicCounterBufferReferencedByVertexShader = 0x92c7,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        /// </summary>
        AtomicCounterBufferReferencedByTessControlShader = 0x92c8,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9
        /// </summary>
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92c9,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        /// </summary>
        AtomicCounterBufferReferencedByGeometryShader = 0x92ca,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        /// </summary>
        AtomicCounterBufferReferencedByFragmentShader = 0x92cb,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC
        /// </summary>
        MaxVertexAtomicCounterBuffers = 0x92cc,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD
        /// </summary>
        MaxTessControlAtomicCounterBuffers = 0x92cd,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE
        /// </summary>
        MaxTessEvaluationAtomicCounterBuffers = 0x92ce,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF
        /// </summary>
        MaxGeometryAtomicCounterBuffers = 0x92cf,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0
        /// </summary>
        MaxFragmentAtomicCounterBuffers = 0x92d0,

        /// <summary>
        /// Original was GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1
        /// </summary>
        MaxCombinedAtomicCounterBuffers = 0x92d1,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2
        /// </summary>
        MaxVertexAtomicCounters = 0x92d2,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3
        /// </summary>
        MaxTessControlAtomicCounters = 0x92d3,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4
        /// </summary>
        MaxTessEvaluationAtomicCounters = 0x92d4,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5
        /// </summary>
        MaxGeometryAtomicCounters = 0x92d5,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6
        /// </summary>
        MaxFragmentAtomicCounters = 0x92d6,

        /// <summary>
        /// Original was GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7
        /// </summary>
        MaxCombinedAtomicCounters = 0x92d7,

        /// <summary>
        /// Original was GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8
        /// </summary>
        MaxAtomicCounterBufferSize = 0x92d8,

        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = 0x92d9,

        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = 0x92da,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        /// </summary>
        UnsignedIntAtomicCounter = 0x92db,

        /// <summary>
        /// Original was GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC
        /// </summary>
        MaxAtomicCounterBufferBindings = 0x92dc,

        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = 0x9380,

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        /// </summary>
        AllBarrierBits = unchecked((int)0xffffffff)
    }
}