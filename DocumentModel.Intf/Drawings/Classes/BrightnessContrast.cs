namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BrightnessContrast Class.
/// </summary>
public class BrightnessContrast: ModelElement
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