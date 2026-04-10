namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Base type for a color for drawing elements.
///   All drawing color types derive from class..
/// </summary>
[OpenXmlType(typeof(DXO10W.ColorType))]
[XmlRoot("WordColorClass", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public class WordColorClass : AbstractColor<DXO10W.ColorType>
{
}