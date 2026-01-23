namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Represents an inline shape (picture, diagram, etc.) within the text flow.
/// </summary>
/// <remarks>
///   Inline shapes flow with surrounding text like characters, as opposed to
///   floating shapes which can be positioned independently.
/// </remarks>
[OpenXmlType(typeof(DXDW.Inline))]
public partial class InlineShape : ModelElement<DXDW.Inline>
{
    /// <summary>
    ///   Gets or sets the width of the inline shape in points.
    /// </summary>
    [OpenXmlElement(typeof(DXDW.Inline))]
#region Properties
    public float Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private float _Width;
    /// <summary>
    ///   Gets or sets the height of the inline shape in points.
    /// </summary>
    [OpenXmlElement(typeof(DXDW.Inline))]
    public float Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

    private float _Height;
    /// <summary>
    ///   Gets the type of the inline shape.
    /// </summary>
    public InlineShapeKind Type { get; }

    /// <summary>
    ///   Gets or sets the alternative text for the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXDW.Inline))]
    public string? AlternativeText { get => _AlternativeText; set => UpdateField(ref _AlternativeText, value, nameof(AlternativeText)); }

    private string? _AlternativeText;
#endregion
}