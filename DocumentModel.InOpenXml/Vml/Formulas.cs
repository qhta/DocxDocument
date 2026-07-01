namespace DocumentModel.Vml;
/// <summary>
///   Defines the Formulas Class.
/// </summary>
[OpenXmlType(typeof(Formula))]
[DataContract]
[XmlRoot("Formulas", Namespace = "DocumentModel.Vml")]
public class Formulas : ModelElementCollection<Formula, DXV.Formulas, DXV.Formula>
{
}