namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single header or footer.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter?view=word-pia"/>
public interface HeaderFooter : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.index?view=word-pia"/>
  public WdHeaderFooterIndex Index { get; }
  /// <summary>
  /// The is header.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.isheader?view=word-pia"/>
  public bool IsHeader { get; }
  /// <summary>
  /// The exists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.exists?view=word-pia"/>
  public bool Exists { get; set; }
  /// <summary>
  /// The page numbers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.pagenumbers?view=word-pia"/>
  public PageNumbers PageNumbers { get; }
  /// <summary>
  /// The link to previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.linktoprevious?view=word-pia"/>
  public bool LinkToPrevious { get; set; }
  /// <summary>
  /// The shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.shapes?view=word-pia"/>
  public Shapes Shapes { get; }

}
