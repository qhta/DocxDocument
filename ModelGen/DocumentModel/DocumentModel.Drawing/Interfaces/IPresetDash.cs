namespace DocumentModel.Drawing;

/// <summary>
/// Preset Dash.
/// </summary>
public interface IPresetDash // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public DocumentModel.Drawing.PresetLineDashValues? Val { get ; set; }
  
}
