namespace DocumentModel.Drawings;
/// <summary>
///   Gradient Stop List.
/// </summary>
[OpenXmlType(typeof(GradientStop))]
[XmlRoot("GradientStopList", Namespace = "DocumentModel.Drawings")]
public class GradientStopList : ModelElementCollection<GradientStop, DXD.GradientStopList, DXD.GradientStop>
{
}