namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a footnote positioned at the bottom of the page or beneath text. The Footnote object is a member of the Footnotes collection. The Footnotes collection represents the footnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote?view=word-pia"/>
public interface IFootnote : IInteropObject
{
  /// <summary>
  /// Returns a <see cref="Range"/> object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns a <see cref="Range"/> object that represents a footnote, endnote, or comment reference mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.reference?view=word-pia"/>
  public Range Reference { get; }

  /// <summary>
  /// Returns an integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.index?view=word-pia"/>
  public int Index { get; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
