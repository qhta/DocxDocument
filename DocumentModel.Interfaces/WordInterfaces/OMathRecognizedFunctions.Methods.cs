namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions?view=word-pia"/>
public partial interface OMathRecognizedFunctions: InteropObject
{
  /// <summary>
  /// Adds a new recognized function to the collection.
  /// </summary>
  /// <param name="Name">The name of the recognized function.</param>
  /// <returns>The created <see cref="OMathRecognizedFunction"/> object.</returns>  
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions.add?view=word-pia"/>
  public OMathRecognizedFunction Add(string Name);
}
