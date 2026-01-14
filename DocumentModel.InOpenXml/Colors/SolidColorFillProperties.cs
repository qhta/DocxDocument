namespace DocumentModel;
/// <summary>
///   Defines the SolidColorFillProperties Class.
/// </summary>
public class SolidColorFillProperties: ModelElement
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