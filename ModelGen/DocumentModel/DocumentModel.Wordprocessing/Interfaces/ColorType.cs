namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface ColorType
{
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor { get ; set; }
  
}
