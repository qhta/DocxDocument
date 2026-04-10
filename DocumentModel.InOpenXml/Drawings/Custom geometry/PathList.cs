namespace DocumentModel.Drawings;
/// <summary>
///   List of Shape Paths.
/// </summary>
[OpenXmlType(typeof(Path))]
[XmlRoot("PathList", Namespace = "DocumentModel.Drawings")]
public class PathList : ModelElementCollection<Path, DXD.PathList, DXD.Path>
{
}