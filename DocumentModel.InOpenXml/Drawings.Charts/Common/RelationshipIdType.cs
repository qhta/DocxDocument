namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RelationshipIdType Class.
/// </summary>
[OpenXmlType(typeof(DXDC.RelationshipIdType))]
[DataContract]
[XmlRoot("RelationshipIdType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class RelationshipIdType : ModelElement<DXDC.RelationshipIdType>
{
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RelationshipIdType.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private string? _Id;
}