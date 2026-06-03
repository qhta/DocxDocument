namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of recognized math functions.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions?view=word-pia"/>
public partial class OMathRecognizedFunctions : InteropCollection<OMathRecognizedFunction>
{


  #region methods

/// <summary>
  /// Adds a new recognized function to the collection.
  /// </summary>
  /// <param name="name">The name of the recognized function.</param>
  /// <returns>The created <see cref="OMathRecognizedFunction"/> object.</returns>  
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions.add?view=word-pia"/>
  public OMathRecognizedFunction Add(string name) { throw new NotImplementedException(); }

  #endregion methods
}
