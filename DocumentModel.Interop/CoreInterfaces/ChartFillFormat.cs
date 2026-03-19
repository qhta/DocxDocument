using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[TypeLibType(4304)]
[Guid("000C171C-0000-0000-C000-000000000046")]
public interface ChartFillFormat
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743808)]
  void OneColorGradient([In] int Style, [In] int Variant, [In] float Degree);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743809)]
  void TwoColorGradient([In] int Style, [In] int Variant);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743810)]
  void PresetTextured([In] int PresetTexture);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743811)]
  void Solid();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743812)]
  void Patterned([In] int Pattern);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743813)]
  void UserPicture
  ([In] [MarshalAs(UnmanagedType.Struct)] object PictureFile,
    [In] [MarshalAs(UnmanagedType.Struct)] object PictureFormat,
    [In] [MarshalAs(UnmanagedType.Struct)] object PictureStackUnit,
    [In] [MarshalAs(UnmanagedType.Struct)] object PicturePlacement);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743814)]
  void UserTextured([In] [MarshalAs(UnmanagedType.BStr)] string TextureFile);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1610743815)]
  void PresetGradient([In] int Style, [In] int Variant, [In] int PresetGradientType);

  [DispId(1610743816)]
  ChartColorFormat BackColor
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743816)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743817)]
  ChartColorFormat ForeColor
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743817)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1610743818)]
  int GradientColorType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743818)]
    get;
  }

  [DispId(1610743819)]
  float GradientDegree
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743819)]
    get;
  }

  [DispId(1610743820)]
  int GradientStyle
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743820)]
    get;
  }

  [DispId(1610743821)]
  int GradientVariant
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743821)]
    get;
  }

  [DispId(1610743822)]
  int Pattern
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743822)]
    get;
  }

  [DispId(1610743823)]
  int PresetGradientType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743823)]
    get;
  }

  [DispId(1610743824)]
  int PresetTexture
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743824)]
    get;
  }

  [DispId(1610743825)]
  string TextureName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743825)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1610743826)]
  int TextureType
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743826)]
    get;
  }

  [DispId(1610743827)]
  int Type
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743827)]
    get;
  }

  [DispId(1610743828)]
  int Visible
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    get;
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1610743828)]
    [param: In]
    set;
  }

  [DispId(148)]
  object Application
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [DispId(149)]
  int Creator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }
}