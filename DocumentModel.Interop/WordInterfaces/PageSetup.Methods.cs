namespace DocumentModel.Interop.Word;

public partial interface PageSetup
{
  /// <summary>
  /// Switches between portrait and landscape page orientations for a document or section.
  /// </summary>
  public void TogglePortrait();
}
