namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public interface ContourColor // : DocumentModel.Wordprocessing.ColorType
{
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
}
