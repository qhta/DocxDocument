namespace DocumentModel.Interop;

/// <summary>
/// Represents a portion of text or a graphic in a page. Use the Rectangle object and related methods and properties for programmatically defining page layout in a document.
/// </summary>
public interface Rectangle : InteropObject
{
  /// <summary>
  /// The rectangle type.
  /// </summary>
  public WdRectangleType RectangleType { get; }
  /// <summary>
  /// The left.
  /// </summary>
  public int Left { get; }
  /// <summary>
  /// The top.
  /// </summary>
  public int Top { get; }
  /// <summary>
  /// The width.
  /// </summary>
  public int Width { get; }
  /// <summary>
  /// The height.
  /// </summary>
  public int Height { get; }
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
  /// <summary>
  /// The lines.
  /// </summary>
  public Lines Lines { get; }

}
