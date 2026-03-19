namespace DocumentModel.Interop.Word;

public partial interface OMathScrPre
{
  /// <summary>
  /// Creates a new script function with both subscript and superscript components based on the current mathematical
  /// object.
  /// </summary>
  /// <remarks>Use this method to convert the current mathematical object into a form that displays both
  /// subscript and superscript, such as for mathematical notations like x_i^j. The returned object allows further
  /// customization of the subscript and superscript values.</remarks>
  /// <returns>An instance of the OMathFunction representing the script function with subscript and superscript applied.</returns>
  public OMathFunction ToScrSubSup();
}
