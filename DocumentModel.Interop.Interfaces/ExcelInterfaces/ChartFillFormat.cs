using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Office.Core;

namespace DocumentModel.Interop.Excel;

[ComImport]
[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDispatchable)]
[Guid("00024435-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface ChartFillFormat
{
  [DispId(148)]
  Application Application
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(148)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(149)]
  XlCreator Creator
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(149)]
    get;
  }

  [DispId(150)]
  object Parent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(150)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1621)]
  void OneColorGradient([In] MsoGradientStyle Style, [In] int Variant, [In] float Degree);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1624)]
  void TwoColorGradient([In] MsoGradientStyle Style, [In] int Variant);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1625)]
  void PresetTextured([In] MsoPresetTexture PresetTexture);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1627)]
  void Solid();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1628)]
  void Patterned([In] MsoPatternType Pattern);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1629)]
  void UserPicture
  ([Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PictureFile,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PictureFormat,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PictureStackUnit,
    [Optional] [In] [MarshalAs(UnmanagedType.Struct)] object PicturePlacement);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1634)]
  void UserTextured([In] [MarshalAs(UnmanagedType.BStr)] string TextureFile);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1636)]
  void PresetGradient([In] MsoGradientStyle Style, [In] int Variant, [In] MsoPresetGradientType PresetGradientType);

  [DispId(1638)]
  ChartColorFormat BackColor
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1638)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1639)]
  ChartColorFormat ForeColor
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1639)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(1640)]
  MsoGradientColorType GradientColorType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1640)]
    get;
  }

  [DispId(1641)]
  float GradientDegree
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1641)]
    get;
  }

  [DispId(1642)]
  MsoGradientStyle GradientStyle
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1642)]
    get;
  }

  [DispId(1643)]
  int GradientVariant
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1643)]
    get;
  }

  [DispId(95)]
  MsoPatternType Pattern
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(95)]
    get;
  }

  [DispId(1637)]
  MsoPresetGradientType PresetGradientType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1637)]
    get;
  }

  [DispId(1626)]
  MsoPresetTexture PresetTexture
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1626)]
    get;
  }

  [DispId(1644)]
  string TextureName
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1644)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [DispId(1645)]
  MsoTextureType TextureType
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1645)]
    get;
  }

  [DispId(108)]
  MsoFillType Type
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(108)]
    get;
  }

  [DispId(558)]
  MsoTriState Visible
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    get;
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(558)]
    [param: In]
    set;
  }
}