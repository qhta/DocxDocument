namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual source, such as a book, journal article, or interview.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source?view=word-pia"/>
public partial interface Source : InteropObject
{
  /// <summary>
  /// The tag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.tag?view=word-pia"/>
  public string Tag { get; }

  /// <summary>
  /// The xml.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.xml?view=word-pia"/>
  public string XML { get; }

  /// <summary>
  /// The cited.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.cited?view=word-pia"/>
  public bool Cited { get; }
}
