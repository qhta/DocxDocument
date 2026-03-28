using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000244DB-0000-0000-C000-000000000046")]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Model
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

  [DispId(3106)]
  ModelTables ModelTables
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3106)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3126)]
  ModelRelationships ModelRelationships
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3126)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(1417)]
  void Refresh();

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3127)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkbookConnection AddConnection([In] [MarshalAs(UnmanagedType.Interface)] WorkbookConnection ConnectionToDataSource);

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3129)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkbookConnection CreateModelWorkbookConnection([In] [MarshalAs(UnmanagedType.Struct)] object ModelTable);

  [DispId(3131)]
  WorkbookConnection DataModelConnection
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3131)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(110)]
  string Name
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(110)]
    [return: MarshalAs(UnmanagedType.BStr)]
    get;
  }

  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [DispId(3132)]
  void Initialize();

  [DispId(3210)]
  ModelMeasures ModelMeasures
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3210)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3211)]
  ModelFormatGeneral ModelFormatGeneral
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3211)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3212)]
  ModelFormatDate ModelFormatDate
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3212)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3214)]
  ModelFormatDecimalNumber ModelFormatDecimalNumber
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3214)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3216)]
  ModelFormatWholeNumber ModelFormatWholeNumber
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3216)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3217)]
  ModelFormatPercentageNumber ModelFormatPercentageNumber
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3217)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3218)]
  ModelFormatScientificNumber ModelFormatScientificNumber
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3218)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3219)]
  ModelFormatCurrency ModelFormatCurrency
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3219)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3221)]
  ModelFormatBoolean ModelFormatBoolean
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3221)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }
}