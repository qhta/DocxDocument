namespace DocumentModel.Interop.Word;

public partial interface HTMLDivisions
{
  /// <summary>
  /// Adds a new HTMLDivision to the collection.
  /// </summary>
  /// <param name="Range">The Range object that represents the range of the new HTMLDivision.</param>
  /// <returns>The newly created <see cref="HTMLDivision"/> object.</returns>
  public HTMLDivision Add(object Range);
}
