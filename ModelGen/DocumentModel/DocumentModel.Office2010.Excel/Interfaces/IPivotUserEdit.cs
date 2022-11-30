namespace DocumentModel.Office2010.Excel;

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
  public DocumentModel.Office2010.Excel.IPivotEditValue? PivotEditValue { get ; set; }
  
}
