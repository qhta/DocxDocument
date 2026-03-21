namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a subdocument within a document or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument?view=word-pia"/>
public partial interface Subdocument : InteropObject
{
  /// <summary>
  /// Returns or sets whether locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Returns whether file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.hasfile?view=word-pia"/>
  public bool HasFile { get; }

  /// <summary>
  /// Returns the level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.level?view=word-pia"/>
  public int Level { get; }
}
