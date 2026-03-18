namespace DocumentModel.Interop;

public partial interface Replacement
{
  /// <summary>
  /// Removes text and paragraph formatting from a selection or from the formatting specified in a find or replace operation.
  /// </summary>
  public void ClearFormatting();
}
