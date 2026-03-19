namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Constraint.
/// </summary>
[OpenXmlType(typeof(DXDD.Constraint))]
public partial class Constraint : ModelElement<DXDD.Constraint>
{
  /// <summary>
  ///   Constraint Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.Type))]
  public ConstraintType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

  private ConstraintType? _Type;
  /// <summary>
  ///   For
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.For))]
  public ConstraintRelationship? For { get => _For; set => UpdateField(ref _For, value, nameof(For)); }

  private ConstraintRelationship? _For;
  /// <summary>
  ///   For Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.ForName))]
  public string? ForName { get => _ForName; set => UpdateField(ref _ForName, value, nameof(ForName)); }

  private string? _ForName;
  /// <summary>
  ///   Data Point Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.PointType))]
  public ElementType? PointType { get => _PointType; set => UpdateField(ref _PointType, value, nameof(PointType)); }

  private ElementType? _PointType;
  /// <summary>
  ///   Reference Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceType))]
  public Constraint? ReferenceType { get => _ReferenceType; set => UpdateField(ref _ReferenceType, value, nameof(ReferenceType)); }

  private Constraint? _ReferenceType;
  /// <summary>
  ///   Reference For
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceFor))]
  public ConstraintRelationship? ReferenceFor { get => _ReferenceFor; set => UpdateField(ref _ReferenceFor, value, nameof(ReferenceFor)); }

  private ConstraintRelationship? _ReferenceFor;
  /// <summary>
  ///   Reference For Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceForName))]
  public string? ReferenceForName { get => _ReferenceForName; set => UpdateField(ref _ReferenceForName, value, nameof(ReferenceForName)); }

  private string? _ReferenceForName;
  /// <summary>
  ///   Reference Point Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.ReferencePointType))]
  public ElementType? ReferencePointType { get => _ReferencePointType; set => UpdateField(ref _ReferencePointType, value, nameof(ReferencePointType)); }

  private ElementType? _ReferencePointType;
  /// <summary>
  ///   Operator
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.Operator))]
  public BoolOperator? Operator { get => _Operator; set => UpdateField(ref _Operator, value, nameof(Operator)); }

  private BoolOperator? _Operator;
  /// <summary>
  ///   Value
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.Val))]
  public Double? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

  private Double? _Val;
  /// <summary>
  ///   Factor
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.Fact))]
  public Double? Fact { get => _Fact; set => UpdateField(ref _Fact, value, nameof(Fact)); }

  private Double? _Fact;
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Constraint.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}