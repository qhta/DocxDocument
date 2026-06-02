namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single version of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version?view=word-pia"/>
public partial class Version : InteropObject
{
  /// <summary>
  /// Returns the name of the user who saved the specified version of the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.savedby?view=word-pia"/>
  public string? SavedBy { get; set; }

  /// <summary>
  /// Returns the comment associated with the specified version of a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.comment?view=word-pia"/>
  public string? Comment { get; set; }

  /// <summary>
  /// The date and time that the document version was saved.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.date?view=word-pia"/>
  public DateTime Date { get; set; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.index?view=word-pia"/>
  public int Index { get; set; }


  #region methods

/// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.version.openold?view=word-pia"/>
  public void OpenOld() { throw new NotImplementedException(); }

  #endregion methods
}
