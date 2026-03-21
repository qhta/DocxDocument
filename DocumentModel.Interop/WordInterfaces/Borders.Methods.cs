namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders?view=word-pia"/>
public partial interface Borders
{
  /// <summary>
  /// Returns a Border object that represents a single border.
  /// </summary>
  /// <param name="Index">A <see cref="WdBorderType"/> value that identifies which border to return.</param>
  /// <returns>The requested <see cref="Border"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.get_item?view=word-pia"/>
  public Border get_Item(WdBorderType Index);

  /// <summary>
  /// Applies the current page border settings to all sections in the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.applypageborderstoallsections?view=word-pia"/>
  public void ApplyPageBordersToAllSections();
}
