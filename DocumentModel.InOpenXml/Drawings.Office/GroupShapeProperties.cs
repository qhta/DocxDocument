namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeProperties Class.
/// </summary>
public partial class GroupShapeProperties : ModelElement<DXOD.GroupShapeProperties>
{
    /// <summary>
    ///   Black and White Mode
    /// </summary>
    public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

    private BlackWhiteMode? _BlackWhiteMode;
    /// <summary>
    ///   2D Transform for Grouped Objects.
    /// </summary>
    public TransformGroup? TransformGroup { get; set; }
    public Fill? Fill { get; set; }
    public EffectList? EffectList { get; set; }
    public EffectDag? EffectDag { get; set; }
    public Scene3DType? Scene3DType { get; set; }
    public IExtensionList? ExtensionList { get; set; }
}