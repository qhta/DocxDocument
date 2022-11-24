namespace DocumentModel.Drawing;

/// <summary>
/// Preset Color.
/// </summary>
public interface IPresetColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public PresetColorValues? Val { get ; set; }
  
}
