namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow?view=word-pia"/>
public partial interface OMathLimLow
{
  /// <summary>
  /// Converts the lower limit to an upper limit in the mathematical function.
  /// </summary>
  /// <returns>The resulting <see cref="OMathFunction"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.tolimupp?view=word-pia"/>
  public OMathFunction ToLimUpp();
}
