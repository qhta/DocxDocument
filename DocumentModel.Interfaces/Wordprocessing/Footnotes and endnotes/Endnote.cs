namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an endnote.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote?view=word-pia"/>
public partial interface Endnote : IModelObject
{
  /// <summary>
  /// Gets the range that contains the endnote text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Gets the range that marks the endnote reference in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote.reference?view=word-pia"/>
  public Range Reference { get; }

  /// <summary>
  /// Gets the index number of the endnote in the `Endnotes` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote.index?view=word-pia"/>
  public int Index { get; }
}
