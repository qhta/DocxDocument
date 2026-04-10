namespace DocumentModel.Drawings;
/// <summary>
///   Represents data for a graphic object, including its Uniform Resource Identifier.
/// </summary>
[OpenXmlType(typeof(DXD.GraphicData))]
[XmlRoot("GraphicData", Namespace = "DocumentModel.Drawings")]
public partial class GraphicData : ModelElement<DXD.GraphicData>
{
 /// <summary>
 ///   Uniform Resource Identifier for the graphic object.
 /// </summary>
 public string? UriString { get => _UriString; set => UpdateField(ref _UriString, value, nameof(UriString)); }

 private string? _UriString;
}