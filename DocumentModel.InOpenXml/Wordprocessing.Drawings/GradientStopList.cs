namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a collection of gradient stops for a gradient fill in a Wordprocessing drawing element.
/// This class provides access to and management of <see cref = "GradientStop"/> objects, enabling the definition of complex color transitions and gradient effects.
/// </summary>
[OpenXmlType(typeof(GradientStop))]
[XmlRoot("GradientStopList", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public class GradientStopList : ModelElementCollection<GradientStop, DXO10W.GradientStopList, DXO10W.GradientStop>
{
}