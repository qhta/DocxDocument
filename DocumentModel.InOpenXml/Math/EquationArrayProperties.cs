namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the array object, including the vertical justification of the object and layout inside the object. 
/// </summary>
[OpenXmlType(typeof(DXM.EquationArrayProperties))]
public partial class EquationArrayProperties : ModelElement<DXM.EquationArrayProperties>
{
 /// <summary>
 ///   Equation Array Base Justification.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.EquationArrayProperties.BaseJustification))]
 /// <summary>
 ///   Equation Array Base Justification.
 /// </summary>
 [OpenXmlElement(typeof(DXM.EquationArrayProperties))]
 public VerticalAlignmentKind? BaseJustification { get => _BaseJustification; set => UpdateField(ref _BaseJustification, value, nameof(BaseJustification)); }

 private VerticalAlignmentKind? _BaseJustification;
 /// <summary>
 ///   Maximum Distribution.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.EquationArrayProperties.MaxDistribution))]
 /// <summary>
 ///   Maximum Distribution.
 /// </summary>
 [OpenXmlElement(typeof(DXM.EquationArrayProperties))]
 public bool? MaxDistribution { get => _MaxDistribution; set => UpdateField(ref _MaxDistribution, value, nameof(MaxDistribution)); }

 private bool? _MaxDistribution;
 /// <summary>
 ///   Object Distribution.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.EquationArrayProperties.ObjectDistribution))]
 /// <summary>
 ///   Object Distribution.
 /// </summary>
 [OpenXmlElement(typeof(DXM.EquationArrayProperties))]
 public bool? ObjectDistribution { get => _ObjectDistribution; set => UpdateField(ref _ObjectDistribution, value, nameof(ObjectDistribution)); }

 private bool? _ObjectDistribution;
 /// <summary>
 ///   Row Spacing (Equation Array). The meaning of the value is unspecified.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.EquationArrayProperties.RowSpacing))]
 /// <summary>
 ///   Row Spacing (Equation Array). The meaning of the value is unspecified.
 /// </summary>
 [OpenXmlElement(typeof(DXM.EquationArrayProperties))]
 public RowSpacing? RowSpacing { get => _RowSpacing; set => UpdateField(ref _RowSpacing, value, nameof(RowSpacing)); }

 private RowSpacing? _RowSpacing;
 /// <summary>
 ///   Specifies formatting of equation array object argument.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.EquationArrayProperties.ControlProperties))]
 /// <summary>
 ///   Specifies formatting of equation array object argument.
 /// </summary>
 [OpenXmlElement(typeof(DXM.EquationArrayProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}