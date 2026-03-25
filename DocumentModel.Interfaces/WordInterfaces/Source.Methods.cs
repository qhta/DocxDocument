namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.source?view=word-pia"/>
public partial interface Source
{
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
}
