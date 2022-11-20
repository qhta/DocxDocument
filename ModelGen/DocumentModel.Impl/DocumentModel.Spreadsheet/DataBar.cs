namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Bar.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormatValueObject))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class DataBar: IDataBar
{
  /// <summary>
  /// Minimum Length
  /// </summary>
  public uint? MinLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Maximum Length
  /// </summary>
  public uint? MaxLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Values
  /// </summary>
  public bool? ShowValue
  {
    get;
    set;
  }
  
}
