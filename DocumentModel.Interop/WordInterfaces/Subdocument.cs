namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a subdocument within a document or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument?view=word-pia"/>
public partial interface Subdocument : InteropObject
{
  /// <summary>
  /// The locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// The has file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.hasfile?view=word-pia"/>
  public bool HasFile { get; }

  /// <summary>
  /// The level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.level?view=word-pia"/>
  public int Level { get; }
}
