﻿// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using System;

namespace ImageMagick
{
    internal abstract class ConstNativeInstance : NativeHelper
    {
        private IntPtr _instance = IntPtr.Zero;

        public IntPtr Instance
        {
            get
            {
                if (_instance == IntPtr.Zero)
                    throw new ObjectDisposedException(TypeName);

                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public bool HasInstance => _instance != IntPtr.Zero;

        protected abstract string TypeName
        {
            get;
        }
    }
}