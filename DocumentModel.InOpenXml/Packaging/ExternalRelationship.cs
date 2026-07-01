namespace DocumentModel.Packaging;
/// <summary>
///   Represents an external relationship to a resource outside the package, as defined by the Open Packaging Conventions (OPC).
/// </summary>
[OpenXmlType(typeof(DXPP.ExternalRelationship))]
[DataContract]
[XmlRoot("ExternalRelationship", Namespace = "DocumentModel.Packaging")]
public abstract class ExternalRelationship : ReferenceRelationship<DXPP.ExternalRelationship>
{
 /// <summary>
 ///   Initializes a new instance of the <see cref = "ExternalRelationship"/> class, representing a link to an external resource.
 /// </summary>
 /// <param name = "externalUri">The target URI of the external resource.</param>
 /// <param name = "relationshipType">The type of the relationship, as defined by the OPC or application.</param>
 /// <param name = "id">The unique identifier for the relationship.</param>
 public ExternalRelationship(Uri? externalUri, string? relationshipType, string? id) : base()
 {
  Uri = externalUri?.ToString();
  RelationshipType = relationshipType;
  Id = id;
  IsExternal = true;
 }
}