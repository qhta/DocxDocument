namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the array object, including the vertical justification of the object and layout inside the object. 
/// </summary>
public partial class EquationArrayProperties : ModelElement<DXM.EquationArrayProperties>
{
    /// <summary>
    ///   Equation Array Base Justification.
    /// </summary>
    public VerticalAlignmentKind? BaseJustification { get => _BaseJustification; set => UpdateField(ref _BaseJustification, value, nameof(BaseJustification)); }

    private VerticalAlignmentKind? _BaseJustification;
    /// <summary>
    ///   Maximum Distribution.
    /// </summary>
    public bool? MaxDistribution { get => _MaxDistribution; set => UpdateField(ref _MaxDistribution, value, nameof(MaxDistribution)); }

    private bool? _MaxDistribution;
    /// <summary>
    ///   Object Distribution.
    /// </summary>
    public bool? ObjectDistribution { get => _ObjectDistribution; set => UpdateField(ref _ObjectDistribution, value, nameof(ObjectDistribution)); }

    private bool? _ObjectDistribution;
    /// <summary>
    ///   Row Spacing (Equation Array). The meaning of the value is unspecified.
    /// </summary>
    public RowSpacing? RowSpacing { get => _RowSpacing; set => UpdateField(ref _RowSpacing, value, nameof(RowSpacing)); }

    private RowSpacing? _RowSpacing;
    /// <summary>
    ///   Specifies formatting of equation array object argument.
    /// </summary>
    public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

    private ControlProperties? _ControlProperties;
}