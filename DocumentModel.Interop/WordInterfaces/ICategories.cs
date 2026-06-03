namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of building block categories.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories?view=word-pia"/>
public interface ICategories : IInteropCollection<ICategory>
{


  #region methods

/// <summary>
  /// Returns a category from the collection by index or name.
  /// </summary>
  /// <param name="index">The numeric index or name of the category.</param>
  /// <returns>The requested <see cref="ICategory"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories.item?view=word-pia"/>
  public ICategory Item(object index);

  #endregion methods
}
