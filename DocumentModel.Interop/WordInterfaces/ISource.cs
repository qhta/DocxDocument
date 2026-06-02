namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual source, such as a book, journal article, or interview.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source?view=word-pia"/>
public interface ISource : IInteropObject
{
  /// <summary>
  /// Returns a String that represents an internal identifying label for a source. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.tag?view=word-pia"/>
  public string Tag { get; }

  /// <summary>
  /// Returns a String that represents the XML markup for a Source object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.xml?view=word-pia"/>
  public string XML { get; }

  /// <summary>
  /// Returns a Boolean that represents whether a source has been cited in a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.cited?view=word-pia"/>
  public bool Cited { get; }


  #region methods

/// <summary>
  /// Gets the value of the specified field from the source.
  /// </summary>
  /// <param name="Name">The name of the field to retrieve.</param>
  /// <returns>The value of the specified field as a string.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.get_field?view=word-pia"/>
  public string Field(string Name);

  /// <summary>
  /// Deletes the specified source.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
