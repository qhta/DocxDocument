using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single header or footer.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter?view=word-pia"/>
public interface IHeaderFooter : IModelObject
{
  /// <summary>
  /// Returns a range object that represents the portion of a document contained in the header or footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.range?view=word-pia"/>
  public IRange Range { get; }
  /// <summary>
  /// Returns a constant that represents the specific header or footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.index?view=word-pia"/>
  public HeaderFooterType Index { get; }
  /// <summary>
  /// Returns true if the object is a header.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.isheader?view=word-pia"/>
  public bool IsHeader { get; }
  /// <summary>
  /// Returns or sets whether the specified header or footer exists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.exists?view=word-pia"/>
  public bool Exists { get; set; }
  /// <summary>
  /// Returns the page numbers collection for the header or footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.pagenumbers?view=word-pia"/>
  public IPageNumbers PageNumbers { get; }
  /// <summary>
  /// Returns or sets whether the header or footer is linked to the corresponding header or footer in the previous section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.linktoprevious?view=word-pia"/>
  public bool LinkToPrevious { get; set; }
  /// <summary>
  /// Returns the shapes collection for the header or footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headerfooter.shapes?view=word-pia"/>
  public Drw.IShapes Shapes { get; }

}
