namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RelationshipType Class.
/// </summary>
public partial class RelationshipType
{
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
}
