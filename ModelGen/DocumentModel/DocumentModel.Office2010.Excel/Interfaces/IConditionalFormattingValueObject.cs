namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattingValueObject Class.
/// </summary>
public interface IConditionalFormattingValueObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.ConditionalFormattingValueObjectTypeKind? Type { get ; set; }
  
  /// <summary>
  /// gte, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? GreaterThanOrEqual { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
