// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium {
    /// <summary>
    /// Structure representing print settings.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
    /// </remarks>
    public class CfxPrintSettings : CfxBase {

        static CfxPrintSettings () {
            CfxApi.cfx_print_settings_create = (CfxApi.cfx_print_settings_create_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_create", typeof(CfxApi.cfx_print_settings_create_delegate));
            CfxApi.cfx_print_settings_is_valid = (CfxApi.cfx_print_settings_is_valid_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_is_valid", typeof(CfxApi.cfx_print_settings_is_valid_delegate));
            CfxApi.cfx_print_settings_is_read_only = (CfxApi.cfx_print_settings_is_read_only_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_is_read_only", typeof(CfxApi.cfx_print_settings_is_read_only_delegate));
            CfxApi.cfx_print_settings_copy = (CfxApi.cfx_print_settings_copy_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_copy", typeof(CfxApi.cfx_print_settings_copy_delegate));
            CfxApi.cfx_print_settings_set_orientation = (CfxApi.cfx_print_settings_set_orientation_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_orientation", typeof(CfxApi.cfx_print_settings_set_orientation_delegate));
            CfxApi.cfx_print_settings_is_landscape = (CfxApi.cfx_print_settings_is_landscape_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_is_landscape", typeof(CfxApi.cfx_print_settings_is_landscape_delegate));
            CfxApi.cfx_print_settings_set_printer_printable_area = (CfxApi.cfx_print_settings_set_printer_printable_area_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_printer_printable_area", typeof(CfxApi.cfx_print_settings_set_printer_printable_area_delegate));
            CfxApi.cfx_print_settings_set_device_name = (CfxApi.cfx_print_settings_set_device_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_device_name", typeof(CfxApi.cfx_print_settings_set_device_name_delegate));
            CfxApi.cfx_print_settings_get_device_name = (CfxApi.cfx_print_settings_get_device_name_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_device_name", typeof(CfxApi.cfx_print_settings_get_device_name_delegate));
            CfxApi.cfx_print_settings_set_dpi = (CfxApi.cfx_print_settings_set_dpi_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_dpi", typeof(CfxApi.cfx_print_settings_set_dpi_delegate));
            CfxApi.cfx_print_settings_get_dpi = (CfxApi.cfx_print_settings_get_dpi_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_dpi", typeof(CfxApi.cfx_print_settings_get_dpi_delegate));
            CfxApi.cfx_print_settings_set_page_ranges = (CfxApi.cfx_print_settings_set_page_ranges_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_page_ranges", typeof(CfxApi.cfx_print_settings_set_page_ranges_delegate));
            CfxApi.cfx_print_settings_get_page_ranges_count = (CfxApi.cfx_print_settings_get_page_ranges_count_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_page_ranges_count", typeof(CfxApi.cfx_print_settings_get_page_ranges_count_delegate));
            CfxApi.cfx_print_settings_get_page_ranges = (CfxApi.cfx_print_settings_get_page_ranges_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_page_ranges", typeof(CfxApi.cfx_print_settings_get_page_ranges_delegate));
            CfxApi.cfx_print_settings_set_selection_only = (CfxApi.cfx_print_settings_set_selection_only_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_selection_only", typeof(CfxApi.cfx_print_settings_set_selection_only_delegate));
            CfxApi.cfx_print_settings_is_selection_only = (CfxApi.cfx_print_settings_is_selection_only_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_is_selection_only", typeof(CfxApi.cfx_print_settings_is_selection_only_delegate));
            CfxApi.cfx_print_settings_set_collate = (CfxApi.cfx_print_settings_set_collate_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_collate", typeof(CfxApi.cfx_print_settings_set_collate_delegate));
            CfxApi.cfx_print_settings_will_collate = (CfxApi.cfx_print_settings_will_collate_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_will_collate", typeof(CfxApi.cfx_print_settings_will_collate_delegate));
            CfxApi.cfx_print_settings_set_color_model = (CfxApi.cfx_print_settings_set_color_model_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_color_model", typeof(CfxApi.cfx_print_settings_set_color_model_delegate));
            CfxApi.cfx_print_settings_get_color_model = (CfxApi.cfx_print_settings_get_color_model_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_color_model", typeof(CfxApi.cfx_print_settings_get_color_model_delegate));
            CfxApi.cfx_print_settings_set_copies = (CfxApi.cfx_print_settings_set_copies_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_copies", typeof(CfxApi.cfx_print_settings_set_copies_delegate));
            CfxApi.cfx_print_settings_get_copies = (CfxApi.cfx_print_settings_get_copies_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_copies", typeof(CfxApi.cfx_print_settings_get_copies_delegate));
            CfxApi.cfx_print_settings_set_duplex_mode = (CfxApi.cfx_print_settings_set_duplex_mode_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_set_duplex_mode", typeof(CfxApi.cfx_print_settings_set_duplex_mode_delegate));
            CfxApi.cfx_print_settings_get_duplex_mode = (CfxApi.cfx_print_settings_get_duplex_mode_delegate)CfxApi.GetDelegate(CfxApi.libcfxPtr, "cfx_print_settings_get_duplex_mode", typeof(CfxApi.cfx_print_settings_get_duplex_mode_delegate));
        }

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxPrintSettings Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxPrintSettings)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxPrintSettings(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxPrintSettings(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new CfxPrintSettings object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public static CfxPrintSettings Create() {
            return CfxPrintSettings.Wrap(CfxApi.cfx_print_settings_create());
        }

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                return 0 != CfxApi.cfx_print_settings_is_valid(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                return 0 != CfxApi.cfx_print_settings_is_read_only(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if the orientation is landscape.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public bool IsLandscape {
            get {
                return 0 != CfxApi.cfx_print_settings_is_landscape(NativePtr);
            }
        }

        /// <summary>
        /// Get the device name.
        /// 
        /// Set the device name.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public String DeviceName {
            get {
                return StringUserfree.Convert(CfxApi.cfx_print_settings_get_device_name(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_print_settings_set_device_name(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Get the DPI (dots per inch).
        /// 
        /// Set the DPI (dots per inch).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public int Dpi {
            get {
                return CfxApi.cfx_print_settings_get_dpi(NativePtr);
            }
            set {
                CfxApi.cfx_print_settings_set_dpi(NativePtr, value);
            }
        }

        /// <summary>
        /// Returns the number of page ranges that currently exist.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public int PageRangesCount {
            get {
                return CfxApi.cfx_print_settings_get_page_ranges_count(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if only the selection will be printed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public bool IsSelectionOnly {
            get {
                return 0 != CfxApi.cfx_print_settings_is_selection_only(NativePtr);
            }
        }

        /// <summary>
        /// Get the color model.
        /// 
        /// Set the color model.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public CfxColorModel ColorModel {
            get {
                return CfxApi.cfx_print_settings_get_color_model(NativePtr);
            }
            set {
                CfxApi.cfx_print_settings_set_color_model(NativePtr, value);
            }
        }

        /// <summary>
        /// Get the number of copies.
        /// 
        /// Set the number of copies.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public int Copies {
            get {
                return CfxApi.cfx_print_settings_get_copies(NativePtr);
            }
            set {
                CfxApi.cfx_print_settings_set_copies(NativePtr, value);
            }
        }

        /// <summary>
        /// Get the duplex mode.
        /// 
        /// Set the duplex mode.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public CfxDuplexMode DuplexMode {
            get {
                return CfxApi.cfx_print_settings_get_duplex_mode(NativePtr);
            }
            set {
                CfxApi.cfx_print_settings_set_duplex_mode(NativePtr, value);
            }
        }

        /// <summary>
        /// Returns a writable copy of this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public CfxPrintSettings Copy() {
            return CfxPrintSettings.Wrap(CfxApi.cfx_print_settings_copy(NativePtr));
        }

        /// <summary>
        /// Set the page orientation.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public void SetOrientation(int landscape) {
            CfxApi.cfx_print_settings_set_orientation(NativePtr, landscape);
        }

        /// <summary>
        /// Set the printer printable area in device units. Some platforms already
        /// provide flipped area. Set |landscapeNeedsFlip| to false (0) on those
        /// platforms to avoid double flipping.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public void SetPrinterPrintableArea(CfxSize physicalSizeDeviceUnits, CfxRect printableAreaDeviceUnits, bool landscapeNeedsFlip) {
            CfxApi.cfx_print_settings_set_printer_printable_area(NativePtr, CfxSize.Unwrap(physicalSizeDeviceUnits), CfxRect.Unwrap(printableAreaDeviceUnits), landscapeNeedsFlip ? 1 : 0);
        }

        /// <summary>
        /// Set the page ranges.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public void SetPageRanges(CfxPageRange[] ranges) {
            int ranges_length = ranges.Length;
            IntPtr[] ranges_ptrs = new IntPtr[ranges_length];
            for(int i = 0; i < ranges_length; ++i) {
                ranges_ptrs[i] = CfxPageRange.Unwrap(ranges[i]);
            }
            PinnedObject ranges_pinned = new PinnedObject(ranges_ptrs);
            int ranges_nomem;
            CfxApi.cfx_print_settings_set_page_ranges(NativePtr, ranges_length, ranges_pinned.PinnedPtr, out ranges_nomem);
            ranges_pinned.Free();
            if(ranges_nomem != 0) {
                throw new OutOfMemoryException();
            }
        }

        /// <summary>
        /// Retrieve the page ranges.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public CfxPageRange[] GetPageRanges() {
            int rangesCount = CfxApi.cfx_print_settings_get_page_ranges_count(NativePtr);
            IntPtr[] pp = new IntPtr[rangesCount];
            PinnedObject pp_pinned = new PinnedObject(pp);
            int ranges_nomem;
            CfxApi.cfx_print_settings_get_page_ranges(NativePtr, ref rangesCount, pp_pinned.PinnedPtr, out ranges_nomem);
            pp_pinned.Free();
            if(ranges_nomem != 0) {
                throw new OutOfMemoryException();
            }
            var retval = new CfxPageRange[rangesCount];
            for(int i = 0; i < rangesCount; ++i) {
                retval[i] = CfxPageRange.WrapOwned(pp[i]);
            }
            return retval;
        }

        /// <summary>
        /// Set whether only the selection will be printed.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public void SetSelectionOnly(int selectionOnly) {
            CfxApi.cfx_print_settings_set_selection_only(NativePtr, selectionOnly);
        }

        /// <summary>
        /// Set whether pages will be collated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public void SetCollate(int collate) {
            CfxApi.cfx_print_settings_set_collate(NativePtr, collate);
        }

        /// <summary>
        /// Returns true (1) if pages will be collated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_settings_capi.h">cef/include/capi/cef_print_settings_capi.h</see>.
        /// </remarks>
        public bool WillCollate() {
            return 0 != CfxApi.cfx_print_settings_will_collate(NativePtr);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}