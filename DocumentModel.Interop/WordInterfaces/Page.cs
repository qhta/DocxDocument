namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a page in a document. Use the Page object and the related methods and properties for programmatically defining page layout in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page?view=word-pia"/>
public partial interface Page : InteropObject
{
  /// <summary>
  /// The left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.left?view=word-pia"/>
  public int Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.top?view=word-pia"/>
  public int Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.width?view=word-pia"/>
  public int Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.height?view=word-pia"/>
  public int Height { get; }

  /// <summary>
  /// The rectangles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.rectangles?view=word-pia"/>
  public Rectangles Rectangles { get; }

  /// <summary>
  /// The breaks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.breaks?view=word-pia"/>
  public Breaks Breaks { get; }

  /// <summary>
  /// The enh meta file bits.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }
}
