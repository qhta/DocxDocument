namespace DocumentModel.Drawing;

/// <summary>
/// Bottom Bevel.
/// </summary>
public interface IBevelBottom // : DocumentFormat.OpenXml.Drawing.BevelType
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
