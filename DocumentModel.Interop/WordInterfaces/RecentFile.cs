namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a recently used file.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile?view=word-pia"/>
public partial interface IRecentFile : IInteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a Long that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// True if changes to the document cannot be saved to the original document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.readonly?view=word-pia"/>
  public bool ReadOnly { get; set; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.path?view=word-pia"/>
  public string Path { get; }


  #region methods

/// <summary>
  /// Opens the specified recent file and returns a Document object that represents the opened document.
  /// </summary>
  /// <returns>A <see cref="Document"/> object representing the opened document.
  /// </returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.open?view=word-pia"/>
  public Document Open();

  #endregion methods
}
