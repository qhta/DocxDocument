namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotUserEdit Class.
/// </summary>
public interface IPivotUserEdit // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotEditValue? PivotEditValue { get ; set; }
  
}
