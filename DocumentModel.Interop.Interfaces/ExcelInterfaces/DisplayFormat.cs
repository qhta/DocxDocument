using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[Guid("000244C2-0000-0000-C000-000000000046")]
public interface DisplayFormat
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

  [DispId(435)]
  Borders Borders
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(435)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(603)]
  Characters Characters
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(603)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(146)]
  Font Font
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(146)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(260)]
  object Style
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(260)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1063)]
  object AddIndent
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1063)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(262)]
  object FormulaHidden
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(262)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(136)]
  object HorizontalAlignment
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(136)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(201)]
  object IndentLevel
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(201)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(129)]
  Interior Interior
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(129)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(269)]
  object Locked
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(269)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(208)]
  object MergeCells
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(208)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(193)]
  object NumberFormat
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(193)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(1097)]
  object NumberFormatLocal
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1097)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(134)]
  object Orientation
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(134)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(975)]
  int ReadingOrder
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(975)]
    get;
  }

  [DispId(209)]
  object ShrinkToFit
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(209)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(137)]
  object VerticalAlignment
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(137)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }

  [DispId(276)]
  object WrapText
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(276)]
    [return: MarshalAs(UnmanagedType.Struct)]
    get;
  }
}