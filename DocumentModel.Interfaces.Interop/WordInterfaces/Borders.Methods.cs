namespace DocumentModel.Interop;

public partial interface Borders
{
  /// <summary>
  /// Returns a Border object that represents a single border.
  /// </summary>
  /// <param name="Index">A <see cref="WdBorderType"/> value that identifies which border to return.</param>
  /// <returns>The requested <see cref="Border"/> object.</returns>
  public Border get_Item(WdBorderType Index);

  /// <summary>
  /// Applies the current page border settings to all sections in the document.
  /// </summary>
  public void ApplyPageBordersToAllSections();
}
