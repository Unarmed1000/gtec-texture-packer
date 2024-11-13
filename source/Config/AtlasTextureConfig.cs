﻿/****************************************************************************************************************************************************
 * Copyright 2020, 2024 NXP
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *
 *    * Redistributions of source code must retain the above copyright notice,
 *      this list of conditions and the following disclaimer.
 *
 *    * Redistributions in binary form must reproduce the above copyright notice,
 *      this list of conditions and the following disclaimer in the documentation
 *      and/or other materials provided with the distribution.
 *
 *    * Neither the name of the NXP. nor the names of
 *      its contributors may be used to endorse or promote products derived from
 *      this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
 * OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 ****************************************************************************************************************************************************/

using MB.Base.MathEx.Pixel;
using MB.RectangleBinPack.TexturePack;
using System;
using System.Diagnostics.CodeAnalysis;

namespace TexturePacker.Config
{
  public readonly struct AtlasTextureConfig : IEquatable<AtlasTextureConfig>
  {
    /// <summary>
    /// The maximum size of the atlas texture
    /// </summary>
    public readonly PxSize2D MaxSize;

    /// <summary>
    /// Atlas texture size restrictions
    /// </summary>
    public readonly TextureSizeRestriction SizeRestriction;

    public AtlasTextureConfig(PxSize2D maxSize, TextureSizeRestriction sizeRestriction)
    {
      MaxSize = maxSize;
      SizeRestriction = sizeRestriction;
    }

    public static bool operator ==(AtlasTextureConfig lhs, AtlasTextureConfig rhs)
      => lhs.MaxSize == rhs.MaxSize && lhs.SizeRestriction == rhs.SizeRestriction;


    public static bool operator !=(AtlasTextureConfig lhs, AtlasTextureConfig rhs) => !(lhs == rhs);


    public override bool Equals([NotNullWhen(true)] object? obj)
      => obj is AtlasTextureConfig objValue && (this == objValue);


    public override int GetHashCode() => HashCode.Combine(MaxSize, SizeRestriction);


    public bool Equals(AtlasTextureConfig other) => this == other;

    public override string ToString() => $"MaxSize: {MaxSize} SizeRestriction: {SizeRestriction}";
  }
}
