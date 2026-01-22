namespace DocumentModel.Math;
/// <summary>
///   Fraction Properties.
/// </summary>
public partial class FractionProperties : ModelElement<DXM.FractionProperties>
{
    /// <summary>
    ///   Fraction type.
    /// </summary>
    public FractionKind? FractionType { get => _FractionType; set => UpdateField(ref _FractionType, value, nameof(FractionType)); }

    private FractionKind? _FractionType;
    /// <summary>
    ///   ControlProperties.
    /// </summary>
    public ControlProperties? ControlProperties { get; set; }
}