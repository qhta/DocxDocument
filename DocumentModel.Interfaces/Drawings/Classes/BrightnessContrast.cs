namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BrightnessContrast interface.
/// </summary>
public interface BrightnessContrast: IModelElement
{
  /// <summary>
  ///   bright, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Bright { get; set; }
  /// <summary>
  ///   contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Contrast { get; set; }
}