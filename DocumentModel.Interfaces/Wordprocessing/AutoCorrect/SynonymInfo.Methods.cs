namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo?view=word-pia"/>
public partial interface SynonymInfo: IModelObject
{
  /// <summary>
  /// Returns the synonym list.
  /// </summary>
  /// <param name="Meaning">Specifies the meaning.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.synonymlist?view=word-pia"/>
  public object SynonymList(object Meaning);
}
