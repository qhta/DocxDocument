namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sources?view=word-pia"/>
public partial interface ISources: IModelObject
{
  /// <summary>
  /// Adds a new source to the collection.
  /// </summary>
  /// <param name="Data">The data for the new source.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sources.add?view=word-pia"/>
  public void Add(string Data);
}
