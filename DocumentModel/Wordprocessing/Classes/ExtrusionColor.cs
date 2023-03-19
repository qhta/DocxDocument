namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public class ExtrusionColor: ModelElement
{
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public SchemeColor? SchemeColor { get; set; }
}