namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormatting Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormattingRule))]
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IReferenceSequence))]
public class ConditionalFormatting: IConditionalFormatting
{
  /// <summary>
  /// pivot, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Pivot
  {
    get;
    set;
  }
  
}
