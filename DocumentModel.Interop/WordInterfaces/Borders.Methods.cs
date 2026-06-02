namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders?view=word-pia"/>
public partial interface IBorders
{
  /// <summary>
  /// Returns a Border object that represents a single border.
  /// </summary>
  /// <param name="Index">A <see cref="BorderType"/> value that identifies which border to return.</param>
  /// <returns>The requested <see cref="Border"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.get_item?view=word-pia"/>
  public Border Item(BorderType Index);

  /// <summary>
  /// Applies the specified page-border formatting to all sections in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.applypageborderstoallsections?view=word-pia"/>
  public void ApplyPageBordersToAllSections();
}
