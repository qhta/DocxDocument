namespace DocumentModel.Interop.Word;

public partial interface OMathLimUpp
{
  /// <summary>
  /// Converts the upper limit to a lower limit in the mathematical function.
  /// </summary>
  /// <returns>The resulting <see cref="OMathFunction"/> object.</returns>
  public OMathFunction ToLimLow();
}
