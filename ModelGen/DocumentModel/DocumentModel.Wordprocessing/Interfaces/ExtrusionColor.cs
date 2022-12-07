namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public interface ExtrusionColor
{
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
}
