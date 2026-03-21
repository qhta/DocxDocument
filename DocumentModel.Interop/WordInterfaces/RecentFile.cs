namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a recently used file.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile?view=word-pia"/>
public partial interface RecentFile : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets whether read only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.readonly?view=word-pia"/>
  public bool ReadOnly { get; set; }

  /// <summary>
  /// Returns the path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.path?view=word-pia"/>
  public string Path { get; }
}
