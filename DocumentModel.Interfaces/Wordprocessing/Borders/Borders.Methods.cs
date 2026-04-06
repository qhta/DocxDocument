namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders?view=word-pia"/>
public partial interface IBorders: IModelObject
{
  /// <summary>
  /// Returns a Border object that represents a single border.
  /// </summary>
  /// <param name="Index">A <see cref="BorderPosition"/> value that identifies which border to return.</param>
  /// <returns>The requested <see cref="IBorder"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.get_item?view=word-pia"/>
  public IBorder Item(BorderPosition Index);

  /// <summary>
  /// Applies the specified page-border formatting to all sections in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.applypageborderstoallsections?view=word-pia"/>
  public void ApplyPageBordersToAllSections();
}
