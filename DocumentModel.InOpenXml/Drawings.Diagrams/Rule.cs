namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Rule.
/// </summary>
[OpenXmlType(typeof(DXDD.Rule))]
[DataContract]
[XmlRoot("Rule", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Rule : ModelElement<DXDD.Rule>
{
 /// <summary>
 ///   Constraint Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Type))]
 public Constraint? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private Constraint? _Type;

 /// <summary>
 ///   For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.For))]
 public ConstraintRelationship? For { get => _For; set => UpdateField(ref _For, value, nameof(For)); }
 private ConstraintRelationship? _For;

 /// <summary>
 ///   For Typeface
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.ForName))]
 public string? ForName { get => _ForName; set => UpdateField(ref _ForName, value, nameof(ForName)); }
 private string? _ForName;

 /// <summary>
 ///   Data Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.PointType))]
 public ElementType? PointType { get => _PointType; set => UpdateField(ref _PointType, value, nameof(PointType)); }
 private ElementType? _PointType;

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Val))]
 public Double? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
 private Double? _Val;

 /// <summary>
 ///   Factor
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Fact))]
 public Double? Fact { get => _Fact; set => UpdateField(ref _Fact, value, nameof(Fact)); }
 private Double? _Fact;

 /// <summary>
 ///   Max Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Max))]
 public Double? Max { get => _Max; set => UpdateField(ref _Max, value, nameof(Max)); }
 private Double? _Max;

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.ExtensionList))]
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private IExtensionList? _ExtensionList;
}