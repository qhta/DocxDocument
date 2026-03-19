namespace DocumentModel.Interop.Word;

public partial interface LinkFormat
{
  /// <summary>
  /// Breaks the link between the source file and the specified OLE object, picture, or linked field.
  /// </summary>
  public void BreakLink();
}
