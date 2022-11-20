namespace DocumentModel.Drawing;

/// <summary>
/// Bevel.
/// </summary>
public interface IBevel // : DocumentFormat.OpenXml.Drawing.BevelType
{
  /// <summary>
  /// Width
  /// </summary>
  public long? Width { get ; set; }
  
  /// <summary>
  /// Height
  /// </summary>
  public long? Height { get ; set; }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public BevelPresetValues? Preset { get ; set; }
  
}
