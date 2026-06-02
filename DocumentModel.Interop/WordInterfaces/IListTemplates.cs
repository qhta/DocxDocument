namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list template objects in the Bullets and Numbering dialog box galleries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates?view=word-pia"/>
public partial interface IListTemplates : IInteropObject, IInteropCollection<ListTemplate>
{


  #region methods

/// <summary>
  /// Adds a list template to the list templates collection.
  /// </summary>
  /// <param name="OutlineNumbered">Specifies whether the list template is outline numbered.</param>
  /// <param name="Name">Specifies the name of the list template.</param>
  /// <returns>The added list template.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates.add?view=word-pia"/>
  public ListTemplate Add(object OutlineNumbered, object Name);

  #endregion methods
}
