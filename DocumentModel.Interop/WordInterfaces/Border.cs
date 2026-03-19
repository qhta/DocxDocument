namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a border of an object.
/// </summary>
public interface Border : InteropObject
{
  /// <summary>
  /// The visible.
  /// </summary>
  public bool Visible { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  public WdColorIndex ColorIndex { get; set; }
  /// <summary>
  /// The inside.
  /// </summary>
  public bool Inside { get; }
  /// <summary>
  /// The line style.
  /// </summary>
  public WdLineStyle LineStyle { get; set; }
  /// <summary>
  /// The line width.
  /// </summary>
  public WdLineWidth LineWidth { get; set; }
  /// <summary>
  /// The art style.
  /// </summary>
  public WdPageBorderArt ArtStyle { get; set; }
  /// <summary>
  /// The art width.
  /// </summary>
  public int ArtWidth { get; set; }
  /// <summary>
  /// The color.
  /// </summary>
  public WdColor Color { get; set; }

}
