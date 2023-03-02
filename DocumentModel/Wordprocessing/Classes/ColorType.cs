namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ColorType Class.
/// </summary>
public record ColorType
{
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}