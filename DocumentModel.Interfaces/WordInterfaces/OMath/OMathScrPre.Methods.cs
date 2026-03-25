namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre?view=word-pia"/>
public partial interface OMathScrPre: InteropObject
{
  /// <summary>
  /// Creates a new script function with both subscript and superscript components based on the current mathematical
  /// object.
  /// </summary>
  /// <remarks>Use this method to convert the current mathematical object into a form that displays both
  /// subscript and superscript, such as for mathematical notations like x_i^j. The returned object allows further
  /// customization of the subscript and superscript values.</remarks>
  /// <returns>An instance of the OMathFunction representing the script function with subscript and superscript applied.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.toscrsubsup?view=word-pia"/>
  public OMathFunction ToScrSubSup();
}
