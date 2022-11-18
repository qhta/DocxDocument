namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattingValueObject Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
public interface IConditionalFormattingValueObject // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public ConditionalFormattingValueObjectType? Type { get ; set; }
  
  /// <summary>
  /// gte, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? GreaterThanOrEqual { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
