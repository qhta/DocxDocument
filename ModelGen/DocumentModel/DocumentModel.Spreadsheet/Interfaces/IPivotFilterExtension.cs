namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtension Class.
/// </summary>
public interface IPivotFilterExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IPivotFilter? PivotFilter { get ; set; }
  
  public IMovingPeriodState? MovingPeriodState { get ; set; }
  
}
