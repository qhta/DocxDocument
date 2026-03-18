namespace DocumentModel.Interop;

public partial interface SynonymInfo
{
  /// <summary>
  /// Returns the synonym list.
  /// </summary>
  /// <param name="Meaning">Specifies the meaning.</param>
  /// <returns>The resulting value.</returns>
  public object SynonymList(object Meaning);
}
