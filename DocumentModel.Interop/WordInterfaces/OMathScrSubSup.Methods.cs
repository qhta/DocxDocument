namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup?view=word-pia"/>
public partial interface OMathScrSubSup
{
  /// <summary>
  /// Removes the subscript and superscript from the specified range and returns an OMathFunction object that represents the removed function.
  /// </summary>
  /// <returns>An instance of the OMathFunction representing the removed subscript and superscript.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.removesub?view=word-pia"/>
  public OMathFunction RemoveSub();
}
