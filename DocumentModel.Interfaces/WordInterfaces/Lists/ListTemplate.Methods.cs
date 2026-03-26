namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate?view=word-pia"/>
public partial interface ListTemplate: InteropObject
{
  /// <summary>
  /// Converts a list template to another list template type.
  /// </summary>
  /// <param name="Level">Specifies the level used for conversion.</param>
  /// <returns>The converted list template.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.convert?view=word-pia"/>
  public ListTemplate Convert(object Level);
}
