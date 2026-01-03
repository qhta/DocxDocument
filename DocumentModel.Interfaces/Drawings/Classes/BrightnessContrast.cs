namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BrightnessContrast interface.
/// </summary>
public interface BrightnessContrast: IModelElement
{
  /// <summary>
  ///   bright
  /// </summary>
  public Int32? Bright { get; set; }
  /// <summary>
  ///   contrast
  /// </summary>
  public Int32? Contrast { get; set; }
}