namespace DocumentModel;
/// <summary>
/// Represents dual font size values in half-points for text formatting, where the first value applies to regular script and the second to complex script.
/// If the complex script value is null, it is assumed to be the same as the regular script value. Used for specifying font sizes that can differ between regular and complex scripts in WordprocessingML documents.
/// </summary>
public partial class FontSizes : ModelElement
{
    /// <summary>
    /// Font size value for regular script, specified in half-points.
    /// </summary>
    public HPS? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private HPS? _Val;
    /// <summary>
    /// Font size value for complex script, specified in half-points. If null, the regular script value is used.
    /// </summary>
    public HPS? ValCS { get => _ValCS; set => UpdateField(ref _ValCS, value, nameof(ValCS)); }

    private HPS? _ValCS;
}