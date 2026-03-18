namespace DocumentModel.Interop;

/// <summary>
/// Represents a page in a document. Use the Page object and the related methods and properties for programmatically defining page layout in a document.
/// </summary>
public partial interface Page : InteropObject
{
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
  /// The rectangles.
  /// </summary>
  public Rectangles Rectangles { get; }

  /// <summary>
  /// The breaks.
  /// </summary>
  public Breaks Breaks { get; }

  /// <summary>
  /// The enh meta file bits.
  /// </summary>
  public object EnhMetaFileBits { get; }
}
