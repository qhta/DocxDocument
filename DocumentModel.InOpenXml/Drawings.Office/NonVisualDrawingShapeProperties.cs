namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualDrawingShapeProperties : ModelElement<DXOD.NonVisualDrawingShapeProperties>
{
    /// <summary>
    ///   Text Box
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.TextBox))]
    public bool? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

    private bool? _TextBox;
    /// <summary>
    ///   Shape Locks.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.ShapeLocks))]
    public ShapeLocks? ShapeLocks { get => _ShapeLocks; set => UpdateField(ref _ShapeLocks, value, nameof(ShapeLocks)); }

    private ShapeLocks? _ShapeLocks;
    /// <summary>
    ///   ExtensionList.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.ExtensionList))]
    public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private IExtensionList? _ExtensionList;
}