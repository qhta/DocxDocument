namespace DocumentModel;
/// <summary>
///   Defines the ColorType Class.
/// </summary>
public interface ColorType: IColor
{
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public RgbColor? RgbColor { get; set; }
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}