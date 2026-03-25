namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions?view=word-pia"/>
public partial interface HTMLDivisions: InteropObject
{
  /// <summary>
  /// Adds a new HTMLDivision to the collection.
  /// </summary>
  /// <param name="Range">The Range object that represents the range of the new HTMLDivision.</param>
  /// <returns>The newly created <see cref="HTMLDivision"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions.add?view=word-pia"/>
  public HTMLDivision Add(object Range);
}
