namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRuleExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IId))]
public class ConditionalFormattingRuleExtension: IConditionalFormattingRuleExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
