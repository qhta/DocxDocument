namespace DocumentModel.Interop;

/// <summary>
/// Represents horizontal line formatting.
/// </summary>
public interface HorizontalLineFormat : InteropObject
{
  /// <summary>
  /// The percent width.
  /// </summary>
  public float PercentWidth { get; set; }
  /// <summary>
  /// The no shade.
  /// </summary>
  public bool NoShade { get; set; }
  /// <summary>
  /// The alignment.
  /// </summary>
  public WdHorizontalLineAlignment Alignment { get; set; }
  /// <summary>
  /// The width type.
  /// </summary>
  public WdHorizontalLineWidthType WidthType { get; set; }

}
