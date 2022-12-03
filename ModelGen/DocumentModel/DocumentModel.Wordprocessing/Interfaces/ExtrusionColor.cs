namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public interface ExtrusionColor // : DocumentModel.Wordprocessing.ColorType
{
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
}
