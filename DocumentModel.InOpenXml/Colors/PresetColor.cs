namespace DocumentModel;
/// <summary>
/// Represents a color using a predefined color allowing colors to be 
/// specified by name (e.g., "Red", "Blue", "AliceBlue") from a standard palette.
/// </summary>
public partial class PresetColor : ModelElement, IColor
{
  /// <summary>
  /// Gets or sets the preset color name that defines the base color.
  /// </summary>
  public PresetColorKind? Val { get; set; }
}