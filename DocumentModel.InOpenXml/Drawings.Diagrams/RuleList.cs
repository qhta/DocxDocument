namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Rule List.
/// </summary>
[OpenXmlType(typeof(DXDD.RuleList))]
[XmlRoot("RuleList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class RuleList : ModelElementCollection<Rule, DXDD.RuleList, DXDD.Rule>
{
}