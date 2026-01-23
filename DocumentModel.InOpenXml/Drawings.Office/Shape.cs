namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the Shape Class.
/// </summary>
public partial class Shape : ModelElement<DXOD.Shape>
{
    /// <summary>
    ///   modelId
    /// </summary>
    public string? ModelId { get => _ModelId; set => UpdateField(ref _ModelId, value, nameof(ModelId)); }

    private string? _ModelId;
    /// <summary>
    ///   ShapeNonVisualProperties.
    /// </summary>
    public ShapeNonVisualProperties? ShapeNonVisualProperties { get => _ShapeNonVisualProperties; set => UpdateField(ref _ShapeNonVisualProperties, value, nameof(ShapeNonVisualProperties)); }

    private ShapeNonVisualProperties? _ShapeNonVisualProperties;
    /// <summary>
    ///   ShapeProperties.
    /// </summary>
    public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

    private ShapeProperties? _ShapeProperties;
    /// <summary>
    ///   ShapeStyle.
    /// </summary>
    public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }

    private ShapeStyle? _ShapeStyle;
    /// <summary>
    ///   TextBody.
    /// </summary>
    public TextBody? TextBody { get => _TextBody; set => UpdateField(ref _TextBody, value, nameof(TextBody)); }

    private TextBody? _TextBody;
    /// <summary>
    ///   Transform2D.
    /// </summary>
    public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

    private Transform2D? _Transform2D;
    /// <summary>
    ///   OfficeArtExtensionList.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}