namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public interface AxisUnits
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.AxisUnit? Unit { get ; set; }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public DocumentModel.Drawings16.Charts.AxisUnitsLabel? AxisUnitsLabel { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
