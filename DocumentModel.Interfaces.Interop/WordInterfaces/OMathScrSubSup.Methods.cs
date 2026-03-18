namespace DocumentModel.Interop;

public partial interface OMathScrSubSup
{
  /// <summary>
  /// Removes the subscript and superscript from the specified range and returns an OMathFunction object that represents the removed function.
  /// </summary>
  /// <returns>An instance of the OMathFunction representing the removed subscript and superscript.</returns>
  public OMathFunction RemoveSub();
}
