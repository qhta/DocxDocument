namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single cascading style sheet attached to a web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet?view=word-pia"/>
public partial interface StyleSheet : InteropObject
{
  /// <summary>
  /// Returns the full name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.fullname?view=word-pia"/>
  public string FullName { get; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.type?view=word-pia"/>
  public WdStyleSheetLinkType Type { get; set; }

  /// <summary>
  /// Returns or sets the title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.title?view=word-pia"/>
  public string Title { get; set; }
}
