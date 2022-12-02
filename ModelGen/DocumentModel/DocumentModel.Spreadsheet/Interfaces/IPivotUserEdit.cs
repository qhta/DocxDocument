namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotUserEdit Class.
/// </summary>
public interface IPivotUserEdit // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public IPivotEditValue? PivotEditValue { get ; set; }
  
}
