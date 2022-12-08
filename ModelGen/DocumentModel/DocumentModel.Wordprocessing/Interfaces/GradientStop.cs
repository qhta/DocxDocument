namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public interface GradientStop
{
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StopPosition { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get ; set; }
  
}
