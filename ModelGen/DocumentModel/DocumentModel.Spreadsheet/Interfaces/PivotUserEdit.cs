namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotUserEdit Class.
/// </summary>
public interface PivotUserEdit // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public PivotEditValue? PivotEditValue { get ; set; }
  
}
