namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Constraint List.
/// </summary>
[OpenXmlType(typeof(DXDD.Constraints))]
[DataContract]
[XmlRoot("Constraints", Namespace = "DocumentModel.Drawings.Diagrams")]
public class Constraints : ModelElementCollection<Constraint, DXDD.Constraints, DXDD.Constraint>
{
}