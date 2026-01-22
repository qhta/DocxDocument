namespace DocumentModel.Vml;
/// <summary>
///   Shape Layout Properties.
/// </summary>
public partial class ShapeLayout : ModelElement<DXVO.ShapeLayout>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Shape ID Map.
    /// </summary>
    public ShapeIdMap? ShapeIdMap { get; set; }
    /// <summary>
    ///   Shape Grouping History.
    /// </summary>
    public RegroupTable? RegroupTable { get; set; }
    /// <summary>
    ///   Rule Set.
    /// </summary>
    public Rules? Rules { get; set; }
}