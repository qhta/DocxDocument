namespace DocumentModel.Drawings;
/// <summary>
///   Gradient Stop List.
/// </summary>
[OpenXmlType(typeof(GradientStop))]
[DataContract]
[XmlRoot("GradientStopList", Namespace = "DocumentModel.Drawings")]
public class GradientStopList : ModelElementCollection<GradientStop, DXD.GradientStopList, DXD.GradientStop>
{
}