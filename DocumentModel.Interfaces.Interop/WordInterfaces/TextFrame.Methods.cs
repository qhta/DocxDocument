namespace DocumentModel.Interop;

public partial interface TextFrame
{
  /// <summary>
  /// Breaks the forward link for the specified text frame, if such a link exists.
  /// </summary>
  public void BreakForwardLink();
}
