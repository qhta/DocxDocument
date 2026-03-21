namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction?view=word-pia"/>
public partial interface OMathFunction
{
  /// <summary>
  /// Removes the mathematical function from the collection.
  /// </summary>
  /// <returns>The removed <see cref="OMathFunction"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.remove?view=word-pia"/>
  public OMathFunction Remove();
}
