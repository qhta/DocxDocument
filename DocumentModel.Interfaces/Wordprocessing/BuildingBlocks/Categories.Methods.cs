namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories?view=word-pia"/>
public partial interface ICategories: IModelObject
{
  /// <summary>
  /// Returns a category from the collection by index or name.
  /// </summary>
  /// <param name="Index">The numeric index or name of the category.</param>
  /// <returns>The requested <see cref="ICategory"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories.item?view=word-pia"/>
  public ICategory Item(object Index);
}
