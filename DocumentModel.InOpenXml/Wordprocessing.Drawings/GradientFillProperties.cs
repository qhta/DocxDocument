namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the properties for a gradient fill applied to a drawing element in a Wordprocessing document.
/// This class provides configuration for gradient stops, linear shading, and path shading, enabling advanced gradient effects and color transitions.
/// </summary>
public partial class GradientFillProperties : ModelElement<DXO10W.GradientFillProperties>
{
    /// <summary>
    /// The list of gradient stops, defining the colors and positions used in the gradient fill.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10W.GradientFillProperties.GradientStopList))]
    /// <summary>
    /// The list of gradient stops, defining the colors and positions used in the gradient fill.
    /// </summary>
    [OpenXmlElement(typeof(DXO10W.GradientFillProperties))]
    public GradientStopList? GradientStopList { get => _GradientStopList; set => UpdateField(ref _GradientStopList, value, nameof(GradientStopList)); }

    private GradientStopList? _GradientStopList;
    /// <summary>
    /// Properties for linear shading, specifying the direction and behavior of a linear gradient fill.
    /// </summary>
    [OpenXmlElement(typeof(DXO10W.GradientFillProperties))]
    public LinearShadeProperties? LinearShadeProperties { get => _LinearShadeProperties; set => UpdateField(ref _LinearShadeProperties, value, nameof(LinearShadeProperties)); }

    private LinearShadeProperties? _LinearShadeProperties;
    /// <summary>
    /// Properties for path shading, specifying the shape and behavior of a path-based gradient fill.
    /// </summary>
    [OpenXmlElement(typeof(DXO10W.GradientFillProperties))]
    public PathShadeProperties? PathShadeProperties { get => _PathShadeProperties; set => UpdateField(ref _PathShadeProperties, value, nameof(PathShadeProperties)); }

    private PathShadeProperties? _PathShadeProperties;
}