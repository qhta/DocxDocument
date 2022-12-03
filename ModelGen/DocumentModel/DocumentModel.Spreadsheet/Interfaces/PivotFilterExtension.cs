namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtension Class.
/// </summary>
public interface PivotFilterExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public PivotFilter? PivotFilter { get ; set; }
  
  public MovingPeriodState? MovingPeriodState { get ; set; }
  
}
