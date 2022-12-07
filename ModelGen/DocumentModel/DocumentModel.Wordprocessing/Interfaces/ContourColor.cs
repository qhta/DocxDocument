namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public interface ContourColor
{
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
}
