namespace DocumentModel.Interop;

public partial interface Categories
{
  /// <summary>
  /// Returns a category from the collection by index or name.
  /// </summary>
  /// <param name="Index">The numeric index or name of the category.</param>
  /// <returns>The requested <see cref="Category"/> object.</returns>
  public Category Item(object Index);
}
