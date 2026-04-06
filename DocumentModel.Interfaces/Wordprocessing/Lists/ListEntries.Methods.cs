namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries?view=word-pia"/>
public partial interface IListEntries: IModelObject
{
  /// <summary>
  /// Adds an item to a drop-down form field.
  /// </summary>
  /// <param name="Name">The name of the item to add.</param>
  /// <param name="Index">The position for the item in the list.</param>
  /// <returns>The added list entry.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries.add?view=word-pia"/>
  public IListEntry Add(string Name, object Index);
}
