namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the GradientStop Class.
/// </summary>
public interface GradientStop: CollectionItem
{
  /// <summary>
  ///   pos
  /// </summary>
  public Int32? StopPosition { get; set; }
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public RgbColor? RgbColor { get; set; }
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}