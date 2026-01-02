namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the AxisUnits Class.
/// </summary>
public class AxisUnits: ModelElement
{
  /// <summary>
  ///   unit, this property is only available in Office 2016 and later.
  /// </summary>
  public AxisUnit? Unit { get; set; }
  /// <summary>
  ///   AxisUnitsLabel.
  /// </summary>
  public AxisUnitsLabel? AxisUnitsLabel { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}