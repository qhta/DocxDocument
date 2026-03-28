namespace DocumentModel.Interop;

/// <summary>
/// Represents an individual line in a Rectangle object of type wdTextRectangle.
/// </summary>
public interface Line : InteropObject
{
  /// <summary>
  /// The line type.
  /// </summary>
  public WdLineType LineType { get; }
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
  /// The rectangles.
  /// </summary>
  public Rectangles Rectangles { get; }

}
