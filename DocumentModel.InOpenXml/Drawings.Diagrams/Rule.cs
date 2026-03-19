namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Rule.
/// </summary>
[OpenXmlType(typeof(DXDD.Rule))]
public class Rule : ModelElement<DXDD.Rule>
{
 /// <summary>
 ///   Constraint Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Type))]
 public Constraint? Type { get; set; }

 /// <summary>
 ///   For
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.For))]
 public ConstraintRelationship? For { get; set; }

 /// <summary>
 ///   For Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.ForName))]
 public string? ForName { get; set; }

 /// <summary>
 ///   Data Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.PointType))]
 public ElementType? PointType { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Val))]
 public Double? Val { get; set; }

 /// <summary>
 ///   Factor
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Fact))]
 public Double? Fact { get; set; }

 /// <summary>
 ///   Max Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.Max))]
 public Double? Max { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Rule.ExtensionList))]
 public ExtensionList? ExtensionList { get; set; }
}