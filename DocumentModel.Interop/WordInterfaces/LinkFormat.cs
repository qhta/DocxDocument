namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the linking characteristics for an OLE object or picture.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat?view=word-pia"/>
public partial interface LinkFormat : InteropObject
{
  /// <summary>
  /// The auto update.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.autoupdate?view=word-pia"/>
  public bool AutoUpdate { get; set; }

  /// <summary>
  /// The source name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.sourcename?view=word-pia"/>
  public string SourceName { get; }

  /// <summary>
  /// The source path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.sourcepath?view=word-pia"/>
  public string SourcePath { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.type?view=word-pia"/>
  public WdLinkType Type { get; }

  /// <summary>
  /// The source full name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.sourcefullname?view=word-pia"/>
  public string SourceFullName { get; set; }

  /// <summary>
  /// The save picture with document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.savepicturewithdocument?view=word-pia"/>
  public bool SavePictureWithDocument { get; set; }
}
