namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public interface AxisUnits
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.AxisUnit? Unit { get ; set; }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? AxisUnitsLabel { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get ; set; }
  
}
