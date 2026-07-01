namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Rule List.
/// </summary>
[OpenXmlType(typeof(DXDD.RuleList))]
[DataContract]
[XmlRoot("RuleList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class RuleList : ModelElementCollection<Rule, DXDD.RuleList, DXDD.Rule>
{
}