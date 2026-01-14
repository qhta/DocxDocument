namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the bevel effect properties for a text run or shape, specifying width, height, and preset profile type for the bevel.
/// This interface enables advanced 3D formatting and appearance customization in WordprocessingML documents.
/// </summary>
public class BevelType: ModelElement
{
    
    /// <summary>
    /// Width of the bevel effect, specifying the horizontal size in EMUs.
    /// </summary>
    public Int64? Width { get; set; }
    
    /// <summary>
    /// Height of the bevel effect, specifying the vertical size in EMUs.
    /// </summary>
    public Int64? Height { get; set; }
    
    /// <summary>
    /// Preset profile type for the bevel, specifying the predefined bevel style.
    /// </summary>
    public BevelPresetKind? PresetProfileType { get; set; }
}