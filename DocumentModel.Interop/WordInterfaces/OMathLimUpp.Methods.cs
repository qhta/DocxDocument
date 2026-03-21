namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp?view=word-pia"/>
public partial interface OMathLimUpp
{
  /// <summary>
  /// Converts the upper limit to a lower limit in the mathematical function.
  /// </summary>
  /// <returns>The resulting <see cref="OMathFunction"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.tolimlow?view=word-pia"/>
  public OMathFunction ToLimLow();
}
