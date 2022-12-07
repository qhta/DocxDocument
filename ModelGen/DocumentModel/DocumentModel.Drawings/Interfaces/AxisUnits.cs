namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public interface AxisUnits
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public AxisUnit? Unit { get ; set; }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public AxisUnitsLabel? AxisUnitsLabel { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
