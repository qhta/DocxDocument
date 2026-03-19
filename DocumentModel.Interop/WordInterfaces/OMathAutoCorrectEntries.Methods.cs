namespace DocumentModel.Interop.Word;

public partial interface OMathAutoCorrectEntries
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Value">Specifies the value.</param>
  /// <returns>The resulting value.</returns>
  public OMathAutoCorrectEntry Add(string Name, string Value);
}
