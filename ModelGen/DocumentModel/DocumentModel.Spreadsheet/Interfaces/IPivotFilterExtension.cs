namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtension Class.
/// </summary>
public interface IPivotFilterExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Excel.IPivotFilter? PivotFilter { get ; set; }
  
  public DocumentModel.Office2013.Excel.IMovingPeriodState? MovingPeriodState { get ; set; }
  
}
