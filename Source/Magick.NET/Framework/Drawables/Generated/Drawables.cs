//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

#if !NETSTANDARD1_3

using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageMagick
{
    public sealed partial class Drawables
    {
        /// <summary>
        /// Adds a new instance of the <see cref="DrawableAffine" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Affine(Matrix matrix)
        {
            _Drawables.Add(new DrawableAffine(matrix));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableBorderColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color of the border.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables BorderColor(Color color)
        {
            _Drawables.Add(new DrawableBorderColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFillColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables FillColor(Color color)
        {
            _Drawables.Add(new DrawableFillColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableRectangle" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Rectangle(Rectangle rectangle)
        {
            _Drawables.Add(new DrawableRectangle(rectangle));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeColor(Color color)
        {
            _Drawables.Add(new DrawableStrokeColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextUnderColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextUnderColor(Color color)
        {
            _Drawables.Add(new DrawableTextUnderColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableViewbox" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Viewbox(Rectangle rectangle)
        {
            _Drawables.Add(new DrawableViewbox(rectangle));
            return this;
        }

    }
}

#endif
