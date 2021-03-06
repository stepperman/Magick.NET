﻿//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://magick.codeplex.com/>
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

namespace ImageMagick
{
  /// <summary>
  /// Specifies the statistic types.
  /// </summary>
  public enum StatisticType
  {
    /// <summary>
    /// Undefined
    /// </summary>
    Undefined,

    /// <summary>
    /// Gradient
    /// </summary>
    Gradient,

    /// <summary>
    /// Maximum
    /// </summary>
    Maximum,

    /// <summary>
    /// Mean
    /// </summary>
    Mean,

    /// <summary>
    /// Median
    /// </summary>
    Median,

    /// <summary>
    /// Minimum
    /// </summary>
    Minimum,

    /// <summary>
    /// Mode
    /// </summary>
    Mode,

    /// <summary>
    /// Nonpeak
    /// </summary>
    Nonpeak,

    /// <summary>
    /// RootMeanSquare
    /// </summary>
    RootMeanSquare,

    /// <summary>
    /// StandardDeviation
    /// </summary>
    StandardDeviation
  }
}