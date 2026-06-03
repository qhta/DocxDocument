namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of building block categories.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories?view=word-pia"/>
public partial class Categories : InteropCollection<Category>
{


  #region methods

/// <summary>
  /// Returns a category from the collection by index or name.
  /// </summary>
  /// <param name="index">The numeric index or name of the category.</param>
  /// <returns>The requested <see cref="Category"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories.item?view=word-pia"/>
  public Category Item(object index) { throw new NotImplementedException(); }

  #endregion methods
}
