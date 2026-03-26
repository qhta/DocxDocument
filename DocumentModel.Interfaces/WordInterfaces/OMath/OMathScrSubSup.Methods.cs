namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup?view=word-pia"/>
public partial interface OMathScrSubSup: InteropObject
{
  /// <summary>
  /// Removes the subscript-superscript formatting from the equation function.
  /// </summary>
  /// <returns>The resulting equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.removesub?view=word-pia"/>
  public OMathFunction RemoveSub();
}
