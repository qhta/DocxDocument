namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a recently used file.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile?view=word-pia"/>
public partial interface RecentFile : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The read only.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.readonly?view=word-pia"/>
  public bool ReadOnly { get; set; }

  /// <summary>
  /// The path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.path?view=word-pia"/>
  public string Path { get; }
}
