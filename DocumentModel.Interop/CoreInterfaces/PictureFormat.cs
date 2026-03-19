using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000C031A-0000-0000-C000-000000000046")]
public interface PictureFormat: _IMsoDispObj
{
  [DispId(1610743808)]
  new object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743808)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(1610743809)]
  new int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743809)]
    get;
  }

  [DispId(1)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(10)]
  void IncrementBrightness([In] float Increment);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(11)]
  void IncrementContrast([In] float Increment);

  [DispId(100)]
  float Brightness
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(100)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(100)]
    [param: In]
    set;
  }

  [DispId(101)]
  MsoPictureColorType ColorType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(101)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(101)]
    [param: In]
    set;
  }

  [DispId(102)]
  float Contrast
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(102)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(102)]
    [param: In]
    set;
  }

  [DispId(103)]
  float CropBottom
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(103)]
    [param: In]
    set;
  }

  [DispId(104)]
  float CropLeft
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(104)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(104)]
    [param: In]
    set;
  }

  [DispId(105)]
  float CropRight
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(105)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(105)]
    [param: In]
    set;
  }

  [DispId(106)]
  float CropTop
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(106)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(106)]
    [param: In]
    set;
  }

  [DispId(107)]
  [ComAliasName("Microsoft.Office.Core.MsoRGBType")]
  int TransparencyColor
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(107)]
    [return: ComAliasName("Microsoft.Office.Core.MsoRGBType")]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(107)]
    [param: In]
    [param: ComAliasName("Microsoft.Office.Core.MsoRGBType")]
    set;
  }

  [DispId(108)]
  MsoTriState TransparentBackground
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    [param: In]
    set;
  }

  [DispId(109)]
  Crop Crop
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(109)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}