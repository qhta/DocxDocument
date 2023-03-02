namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public record ContourColor
{
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public SchemeColor? SchemeColor { get; set; }
}