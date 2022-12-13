namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public interface ExtrusionColor
{
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor { get ; set; }
  
}
