namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldsUsage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldUsage))]
public class FieldsUsage: IFieldsUsage
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
