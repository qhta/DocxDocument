namespace DocumentModel.Interop;

public partial interface ListTemplate
{
  /// <summary>
  /// Converts the list template to a different level or format.
  /// </summary>
  /// <param name="Level">The level or format to convert to.</param>
  /// <returns>The converted <see cref="ListTemplate"/> object.</returns>
  public ListTemplate Convert(object Level);
}
