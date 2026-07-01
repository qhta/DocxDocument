namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Point List.
/// </summary>
[OpenXmlType(typeof(DXDD.PointList))]
[DataContract]
[XmlRoot("PointList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class PointList : ModelElementCollection<Point, DXDD.PointList, DXDD.Point>
{
}