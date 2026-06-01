namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the linking characteristics for an OLE object or picture.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat?view=word-pia"/>
public partial class LinkFormat : InteropObject
{
  /// <summary>
  /// Returns or sets whether the linked object is updated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.autoupdate?view=word-pia"/>
  public bool AutoUpdate { get; set; }

  /// <summary>
  /// Returns the source file name for the linked object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.sourcename?view=word-pia"/>
  public string SourceName { get; }

  /// <summary>
  /// Returns the source path for the linked object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.sourcepath?view=word-pia"/>
  public string SourcePath { get; }

  /// <summary>
  /// Returns or sets whether the link is locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns the type of linked object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.type?view=word-pia"/>
  public LinkType Type { get; }

  /// <summary>
  /// Returns or sets the full path and file name of the source for the linked object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.sourcefullname?view=word-pia"/>
  public string SourceFullName { get; set; }

  /// <summary>
  /// Returns or sets whether the linked picture is saved with the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.savepicturewithdocument?view=word-pia"/>
  public bool SavePictureWithDocument { get; set; }
}
