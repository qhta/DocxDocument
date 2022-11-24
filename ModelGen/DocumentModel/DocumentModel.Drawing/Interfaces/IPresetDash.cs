namespace DocumentModel.Drawing;

/// <summary>
/// Preset Dash.
/// </summary>
public interface IPresetDash // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public PresetLineDashValues? Val { get ; set; }
  
}
