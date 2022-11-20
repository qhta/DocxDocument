namespace DocumentModel.Drawing;

/// <summary>
/// Preset Dash.
/// </summary>
public class PresetDash: IPresetDash
{
  /// <summary>
  /// Value
  /// </summary>
  public DocumentModel.Drawing.PresetLineDashValues? Val
  {
    get;
    set;
  }
  
}
