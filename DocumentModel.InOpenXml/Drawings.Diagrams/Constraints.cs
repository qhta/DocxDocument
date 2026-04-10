namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Constraint List.
/// </summary>
[OpenXmlType(typeof(DXDD.Constraints))]
[XmlRoot("Constraints", Namespace = "DocumentModel.Drawings.Diagrams")]
public class Constraints : ModelElementCollection<Constraint, DXDD.Constraints, DXDD.Constraint>
{
}