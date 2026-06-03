using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000244E4-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeLibType(TypeLibTypeFlags.FDispatchable)]
public interface ModelChanges
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

  [DispId(3145)]
  ModelTableNames TablesAdded
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3145)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3146)]
  ModelTableNames TablesDeleted
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3146)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3147)]
  ModelTableNames TablesModified
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3147)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3148)]
  ModelTableNameChanges TableNamesChanged
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3148)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3149)]
  bool RelationshipChange
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3149)]
    get;
  }

  [DispId(3150)]
  ModelColumnNames ColumnsAdded
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3150)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3151)]
  ModelColumnNames ColumnsDeleted
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3151)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3152)]
  ModelColumnChanges ColumnsChanged
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3152)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3153)]
  ModelMeasureNames MeasuresAdded
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3153)]
    [return: MarshalAs(UnmanagedType.Interface)]
    get;
  }

  [DispId(3154)]
  bool UnknownChange
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(3154)]
    get;
  }

  [DispId(222)]
  XlModelChangeSource Source
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall,
      MethodCodeType = MethodCodeType.Runtime)]
    [DispId(222)]
    get;
  }
}