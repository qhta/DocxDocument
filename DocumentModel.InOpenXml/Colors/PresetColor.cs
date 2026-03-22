namespace DocumentModel;
/// <summary>
/// Represents a color using a predefined color allowing colors to be 
/// specified by name (e.g., "Red", "Blue", "AliceBlue") from a standard palette.
/// </summary>
[OpenXmlType(typeof(DXD.PresetColor))]
public partial class PresetColor : AbstractColor<DXD.PresetColor>
{
 /// <summary>
 /// Gets or sets the preset color name that defines the base color.
 /// </summary>
 public PresetColors? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
 private PresetColors? _Val;
}