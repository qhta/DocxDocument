namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SolidColorFillProperties Class.
/// </summary>
public record SolidColorFillProperties
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