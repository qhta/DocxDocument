namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public class ContourColor: ModelElement
{
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public SchemeColor? SchemeColor { get; set; }
}