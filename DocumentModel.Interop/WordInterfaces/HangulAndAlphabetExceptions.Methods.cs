namespace DocumentModel.Interop.Word;

public partial interface HangulAndAlphabetExceptions
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <returns>The resulting value.</returns>
  public HangulAndAlphabetException Add(string Name);
}
