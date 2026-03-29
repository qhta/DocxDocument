namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow?view=word-pia"/>
public partial interface OMathLimLow: InteropObject
{
  /// <summary>
  /// Converts the lower-limit construct to an upper-limit construct.
  /// </summary>
  /// <returns>The resulting equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.tolimupp?view=word-pia"/>
  public OMathFunction ToLimUpp();
}
