namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate?view=word-pia"/>
public partial interface ListTemplate
{
  /// <summary>
  /// Converts the list template to a different level or format.
  /// </summary>
  /// <param name="Level">The level or format to convert to.</param>
  /// <returns>The converted <see cref="ListTemplate"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.convert?view=word-pia"/>
  public ListTemplate Convert(object Level);
}
