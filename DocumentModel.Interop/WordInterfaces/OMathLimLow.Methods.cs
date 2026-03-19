namespace DocumentModel.Interop.Word;

public partial interface OMathLimLow
{
  /// <summary>
  /// Converts the lower limit to an upper limit in the mathematical function.
  /// </summary>
  /// <returns>The resulting <see cref="OMathFunction"/> object.</returns>
  public OMathFunction ToLimUpp();
}
