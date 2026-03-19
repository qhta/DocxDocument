namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Constraint.
/// </summary>
[OpenXmlType(typeof(DXDD.Constraint))]
public class Constraint : ModelElement<DXDD.Constraint>
{
 /// <summary>
 ///   Constraint Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Type))]
 public ConstraintType? Type { get; set; }

 /// <summary>
 ///   For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.For))]
 public ConstraintRelationship? For { get; set; }

 /// <summary>
 ///   For Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ForName))]
 public string? ForName { get; set; }

 /// <summary>
 ///   Data Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.PointType))]
 public ElementType? PointType { get; set; }

 /// <summary>
 ///   Reference Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceType))]
 public Constraint? ReferenceType { get; set; }

 /// <summary>
 ///   Reference For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceFor))]
 public ConstraintRelationship? ReferenceFor { get; set; }

 /// <summary>
 ///   Reference For Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferenceForName))]
 public string? ReferenceForName { get; set; }

 /// <summary>
 ///   Reference Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ReferencePointType))]
 public ElementType? ReferencePointType { get; set; }

 /// <summary>
 ///   Operator
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Operator))]
 public BoolOperator? Operator { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Val))]
 public Double? Val { get; set; }

 /// <summary>
 ///   Factor
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.Fact))]
 public Double? Fact { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Constraint.ExtensionList))]
 public ExtensionList? ExtensionList { get; set; }
}