namespace DocumentModel.Vml;
/// <summary>
///   Shape ID Map.
/// </summary>
public partial class ShapeIdMap : ModelElement<DXVO.ShapeIdMap>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Shape IDs
    /// </summary>
    public string? Data { get; set; }
}