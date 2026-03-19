namespace DocumentModel.Interop.Word;

public partial interface Bibliography
{
  /// <summary>
  /// Generates a unique tag for a bibliography source.
  /// </summary>
  /// <returns>A unique source tag string.</returns>
  public string GenerateUniqueTag();
}
