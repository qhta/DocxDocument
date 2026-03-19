namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Constraint.
/// </summary>
[OpenXmlType(typeof(DXDD.Constraint))]
/// <summary>
/// Represents the Constraint.
/// </summary>
public class Constraint : ModelElement<DXDD.Constraint>
{
 /// <summary>
 ///   Constraint Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public ConstraintType? Type { get; set; }

 /// <summary>
 ///   For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.For))]
 /// <summary>
 /// For.
 /// </summary>
 public ConstraintRelationship? For { get; set; }

 /// <summary>
 ///   For Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ForName))]
 /// <summary>
 /// For Name.
 /// </summary>
 public string? ForName { get; set; }

 /// <summary>
 ///   Data Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.PointType))]
 /// <summary>
 /// Point Type.
 /// </summary>
 public ElementType? PointType { get; set; }

 /// <summary>
 ///   Reference Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceType))]
 /// <summary>
 /// Reference Type.
 /// </summary>
 public Constraint? ReferenceType { get; set; }

 /// <summary>
 ///   Reference For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceFor))]
 /// <summary>
 /// Reference For.
 /// </summary>
 public ConstraintRelationship? ReferenceFor { get; set; }

 /// <summary>
 ///   Reference For Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceForName))]
 /// <summary>
 /// Reference For Name.
 /// </summary>
 public string? ReferenceForName { get; set; }

 /// <summary>
 ///   Reference Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferencePointType))]
 /// <summary>
 /// Reference Point Type.
 /// </summary>
 public ElementType? ReferencePointType { get; set; }

 /// <summary>
 ///   Operator
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Operator))]
 /// <summary>
 /// Operator.
 /// </summary>
 public BoolOperator? Operator { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public Double? Val { get; set; }

 /// <summary>
 ///   Factor
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Fact))]
 /// <summary>
 /// Fact.
 /// </summary>
 public Double? Fact { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ExtensionList))]
 /// <summary>
 /// Extension List.
 /// </summary>
 public ExtensionList? ExtensionList { get; set; }
}

