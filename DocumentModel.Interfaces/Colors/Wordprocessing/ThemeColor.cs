namespace DocumentModel.Wordprocessing;
/// <summary>
///   Theme color interface.
/// </summary>
public interface ThemeColor : DM.Color
{
  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  public ThemeColorIndex Index { get; set; }
  /// <summary>
  ///   Specifies a lighter version of its input color. A 10% tint is 10% of the input color combined with 90% white.
  /// </summary>
  public Percent? Tint { get; set; }
  /// <summary>
  /// Specifies a darker version of its input color. A 10% shade is 10% of the input color combined with 90% black.
  /// </summary>
  public Percent? Shade { get; set; }
}