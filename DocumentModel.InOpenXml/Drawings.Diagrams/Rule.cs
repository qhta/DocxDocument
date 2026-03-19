namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Rule.
/// </summary>
[OpenXmlType(typeof(DXDD.Rule))]
/// <summary>
/// Represents the Rule.
/// </summary>
public class Rule : ModelElement<DXDD.Rule>
{
 /// <summary>
 ///   Constraint Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public Constraint? Type { get; set; }

 /// <summary>
 ///   For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.For))]
 /// <summary>
 /// For.
 /// </summary>
 public ConstraintRelationship? For { get; set; }

 /// <summary>
 ///   For Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.ForName))]
 /// <summary>
 /// For Name.
 /// </summary>
 public string? ForName { get; set; }

 /// <summary>
 ///   Data Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.PointType))]
 /// <summary>
 /// Point Type.
 /// </summary>
 public ElementType? PointType { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public Double? Val { get; set; }

 /// <summary>
 ///   Factor
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Fact))]
 /// <summary>
 /// Fact.
 /// </summary>
 public Double? Fact { get; set; }

 /// <summary>
 ///   Max Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Max))]
 /// <summary>
 /// Max.
 /// </summary>
 public Double? Max { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.ExtensionList))]
 /// <summary>
 /// Extension List.
 /// </summary>
 public ExtensionList? ExtensionList { get; set; }
}

