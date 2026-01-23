namespace DocumentModel.Drawings;
/// <summary>
///   Represents a preset geometry for a shape, including the preset type and optional adjustment values.
/// </summary>
public partial class PresetGeometry : ModelElement<DXD.PresetGeometry>
{
    /// <summary>
    ///   Preset shape type.
    /// </summary>
    public ShapeKind? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

    private ShapeKind? _Preset;
    /// <summary>
    ///   List of adjustment values for the preset shape.
    /// </summary>
    public AdjustValueList? AdjustValueList { get => _AdjustValueList; set => UpdateField(ref _AdjustValueList, value, nameof(AdjustValueList)); }

    private AdjustValueList? _AdjustValueList;
}