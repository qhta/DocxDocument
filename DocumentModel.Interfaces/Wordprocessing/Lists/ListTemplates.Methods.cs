namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates?view=word-pia"/>
public partial interface IListTemplates: IModelObject
{
  /// <summary>
  /// Adds a list template to the list templates collection.
  /// </summary>
  /// <param name="OutlineNumbered">Specifies whether the list template is outline numbered.</param>
  /// <param name="Name">Specifies the name of the list template.</param>
  /// <returns>The added list template.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates.add?view=word-pia"/>
  public IListTemplate Add(object OutlineNumbered, object Name);
}
