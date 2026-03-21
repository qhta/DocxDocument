namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates?view=word-pia"/>
public partial interface ListTemplates
{
  /// <summary>
  /// Adds a new list template to the collection.
  /// </summary>
  /// <param name="OutlineNumbered">true to create an outline-numbered list template; otherwise, false.</param>
  /// <param name="Name">The name of the new list template.</param>
  /// <returns>The created <see cref="ListTemplate"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates.add?view=word-pia"/>
  public ListTemplate Add(object OutlineNumbered, object Name);
}
