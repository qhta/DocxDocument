namespace DocumentModel.Interop.Word;

public partial interface View
{
  /// <summary>
  /// Collapses the outline at the specified range.
  /// </summary>
  /// <param name="Range">The range where the outline should be collapsed.</param>
  public void CollapseOutline(object Range);
}
