namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public class BrightnessContrast: IBrightnessContrast
{
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Bright
  {
    get;
    set;
  }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Contrast
  {
    get;
    set;
  }
  
}
