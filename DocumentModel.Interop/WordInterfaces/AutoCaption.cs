namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single caption that can be automatically added when items such as tables, pictures, or OLE objects are inserted into a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption?view=word-pia"/>
public interface AutoCaption : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The auto insert.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.autoinsert?view=word-pia"/>
  public bool AutoInsert { get; set; }
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// The caption label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaption.captionlabel?view=word-pia"/>
  public CaptionLabel CaptionLabel { get; set; }

}
