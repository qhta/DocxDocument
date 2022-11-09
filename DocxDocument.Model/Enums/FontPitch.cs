namespace DocxDocument.Model;

/// <summary>
/// Specifies the pitch of the font: default, fixed or variable
/// </summary>
public enum FontPitch
{
  /// <summary>
  /// The pitch is irrelevant.
  /// </summary>
  Default,

  /// <summary>
  /// Fixed width of all characters.
  /// </summary>
  Fixed,

  /// <summary>
  /// Variable width of characters.
  /// </summary>
  Variable
}