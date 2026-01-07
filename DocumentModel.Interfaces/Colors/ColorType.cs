namespace DocumentModel;
/// <summary>
///   Defines the ColorType Class.
/// </summary>
public interface ColorType: AbstractColor
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