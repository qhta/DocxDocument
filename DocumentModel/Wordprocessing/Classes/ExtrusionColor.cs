namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public record ExtrusionColor
{
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public SchemeColor? SchemeColor { get; set; }
}