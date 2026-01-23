namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the bevel effect properties for a text run or shape, specifying width, height, and preset profile type for the bevel.
/// This class enables advanced 3D formatting and appearance customization in WordprocessingML documents.
/// </summary>
public partial class BevelType : ModelElement<DXO10W.BevelType>
{
    /// <summary>
    /// Width of the bevel effect, specifying the horizontal size in EMUs.
    /// </summary>
    public Int64? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private Int64? _Width;
    /// <summary>
    /// Height of the bevel effect, specifying the vertical size in EMUs.
    /// </summary>
    public Int64? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

    private Int64? _Height;
    /// <summary>
    /// Preset profile type for the bevel, specifying the predefined bevel style.
    /// </summary>
    public BevelPresetKind? PresetProfileType { get => _PresetProfileType; set => UpdateField(ref _PresetProfileType, value, nameof(PresetProfileType)); }

    private BevelPresetKind? _PresetProfileType;
}