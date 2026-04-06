namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate?view=word-pia"/>
public partial interface IListTemplate: IModelObject
{
  /// <summary>
  /// Converts a list template to another list template type.
  /// </summary>
  /// <param name="Level">Specifies the level used for conversion.</param>
  /// <returns>The converted list template.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.convert?view=word-pia"/>
  public IListTemplate Convert(object Level);
}
