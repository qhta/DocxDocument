namespace DocumentModel.Packaging;
[OpenXmlType(typeof(DXPP.ExternalRelationship))]
public class ExternalRelationship : ReferenceRelationship<DXPP.ExternalRelationship>
{
 /// <summary>
 /// Initializes a new instance of the ExternalRelationship.
 /// </summary>
 /// <param name = "externalUri">The target uri of the relationship.</param>
 /// <param name = "relationshipType">The relationship type.</param>
 /// <param name = "id">The relationship ID.</param>
 public ExternalRelationship(Uri? externalUri, string? relationshipType, string? id) : base()
 {
  Uri = externalUri?.ToString();
  RelationshipType = relationshipType;
  Id = id;
  IsExternal = true;
 }
}