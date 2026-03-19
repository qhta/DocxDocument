namespace DocumentModel.Interop.Word;

public partial interface ListTemplates
{
  /// <summary>
  /// Adds a new list template to the collection.
  /// </summary>
  /// <param name="OutlineNumbered">true to create an outline-numbered list template; otherwise, false.</param>
  /// <param name="Name">The name of the new list template.</param>
  /// <returns>The created <see cref="ListTemplate"/> object.</returns>
  public ListTemplate Add(object OutlineNumbered, object Name);
}
