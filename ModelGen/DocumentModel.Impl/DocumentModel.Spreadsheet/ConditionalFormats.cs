namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormat))]
public class ConditionalFormats: IConditionalFormats
{
  /// <summary>
  /// Conditional Format Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
