namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the properties for a linear gradient shade applied to a drawing element in a Wordprocessing document.
/// This interface provides configuration for the angle and scaling of the linear gradient, enabling precise control over gradient direction and behavior.
/// </summary>
public partial class LinearShadeProperties : ModelElement
{
    /// <summary>
    /// The angle of the linear gradient, specified in degrees, determining the direction of the gradient fill.
    /// </summary>
    public Int32? Angle { get => _Angle; set => UpdateField(ref _Angle, value, nameof(Angle)); }

    private Int32? _Angle;
    /// <summary>
    /// Indicates whether the gradient is scaled to fit the shape, affecting how the gradient is rendered within the element.
    /// </summary>
    public OnOffKind? Scaled { get; set; }
}