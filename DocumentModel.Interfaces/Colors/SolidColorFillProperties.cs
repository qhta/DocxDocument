namespace DocumentModel;
/// <summary>
///   Defines the SolidColorFillProperties Class.
/// </summary>
public interface SolidColorFillProperties
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