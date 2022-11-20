namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormat))]
public class ConditionalFormats: IConditionalFormats
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
