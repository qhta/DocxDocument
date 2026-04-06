namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions?view=word-pia"/>
public partial interface IOMathRecognizedFunctions: IModelObject
{
  /// <summary>
  /// Adds a new recognized function to the collection.
  /// </summary>
  /// <param name="Name">The name of the recognized function.</param>
  /// <returns>The created <see cref="IOMathRecognizedFunction"/> object.</returns>  
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions.add?view=word-pia"/>
  public IOMathRecognizedFunction Add(string Name);
}
