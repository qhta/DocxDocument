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
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor { get ; set; }
  
}
