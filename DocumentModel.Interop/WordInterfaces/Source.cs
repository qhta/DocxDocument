namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual source, such as a book, journal article, or interview.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source?view=word-pia"/>
public partial interface Source : InteropObject
{
  /// <summary>
  /// The tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.tag?view=word-pia"/>
  public string Tag { get; }

  /// <summary>
  /// The xml.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.xml?view=word-pia"/>
  public string XML { get; }

  /// <summary>
  /// The cited.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.cited?view=word-pia"/>
  public bool Cited { get; }
}
