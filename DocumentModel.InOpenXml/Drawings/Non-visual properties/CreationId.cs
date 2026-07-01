namespace DocumentModel.Drawings;
/// <summary>
///   Represents a unique creation identifier for a drawing element.
/// </summary>
[OpenXmlType(typeof(DXO16D.CreationId))]
[DataContract]
[XmlRoot("CreationId", Namespace = "DocumentModel.Drawings")]
public partial class CreationId : ModelElement<DXO16D.CreationId>
{
 /// <summary>
 ///   Unique identifier value.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16D.CreationId.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;
}