namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public interface ExtrusionColor
{
  public RgbColor? RgbColor { get; set; }
  public SchemeColor? SchemeColor { get; set; }
}