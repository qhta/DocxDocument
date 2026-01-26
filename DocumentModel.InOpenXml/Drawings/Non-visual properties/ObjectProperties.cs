namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for an embedded object, including its identifier, ActiveX status, and link type.
/// </summary>
[OpenXmlType(typeof(DXO13D.ObjectProperties))]
public partial class ObjectProperties : ModelElement<DXO13D.ObjectProperties>
{
 /// <summary>
 ///   Identifier for the embedded object.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.ObjectProperties.Id))]
 [OpenXmlElement(typeof(DXO13D.ObjectProperties))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Indicates whether the object is an ActiveX control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.ObjectProperties.IsActiveX))]
 [OpenXmlElement(typeof(DXO13D.ObjectProperties))]
 public bool? IsActiveX { get => _IsActiveX; set => UpdateField(ref _IsActiveX, value, nameof(IsActiveX)); }

 private bool? _IsActiveX;
 /// <summary>
 ///   Type of link associated with the object.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.ObjectProperties.LinkType))]
 [OpenXmlElement(typeof(DXO13D.ObjectProperties))]
 public string? LinkType { get => _LinkType; set => UpdateField(ref _LinkType, value, nameof(LinkType)); }

 private string? _LinkType;
}