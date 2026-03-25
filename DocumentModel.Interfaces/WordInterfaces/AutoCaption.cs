namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single caption that can be automatically added when items such as tables, pictures, or OLE objects are inserted into a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption?view=word-pia"/>
public interface AutoCaption : InteropObject
{
  /// <summary>
  /// Gets the name of the auto caption entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets a value indicating whether the caption label is inserted automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.autoinsert?view=word-pia"/>
  public bool AutoInsert { get; set; }
  /// <summary>
  /// Gets the index number of the auto caption entry in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the caption label associated with the auto caption entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.captionlabel?view=word-pia"/>
  public CaptionLabel CaptionLabel { get; set; }

}
