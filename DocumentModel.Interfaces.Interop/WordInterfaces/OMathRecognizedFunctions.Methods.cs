namespace DocumentModel.Interop;

public partial interface OMathRecognizedFunctions
{
  /// <summary>
  /// Adds a new recognized function to the collection.
  /// </summary>
  /// <param name="Name">The name of the recognized function.</param>
  /// <returns>The created <see cref="OMathRecognizedFunction"/> object.</returns>  
  public OMathRecognizedFunction Add(string Name);
}
