namespace DocumentModel.Interop.Word;

public partial interface FirstLetterExceptions
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <returns>The resulting value.</returns>
  public FirstLetterException Add(string Name);
}
