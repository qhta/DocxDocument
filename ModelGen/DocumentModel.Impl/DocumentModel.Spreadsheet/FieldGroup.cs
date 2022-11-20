namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDiscreteProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupItems))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRangeProperties))]
public class FieldGroup: IFieldGroup
{
  /// <summary>
  /// Parent
  /// </summary>
  public uint? ParentId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Base
  /// </summary>
  public uint? Base
  {
    get;
    set;
  }
  
}
