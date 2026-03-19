namespace DocumentModel.Interop.Word;

public partial interface TextEffectFormat
{
  /// <summary>
  /// Switches the text flow in the specified WordArt from horizontal to vertical, or vice versa.
  /// </summary>
  public void ToggleVerticalText();
}
