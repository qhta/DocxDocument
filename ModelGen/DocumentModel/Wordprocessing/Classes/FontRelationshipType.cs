namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontRelationshipType Class.
/// </summary>
public partial class FontRelationshipType
{
  
  /// <summary>
  ///   fontKey
  /// </summary>
  [SchemaAttr("w:fontKey")]
  public String? FontKey { get; set; }
  
  
  /// <summary>
  ///   subsetted
  /// </summary>
  [SchemaAttr("w:subsetted")]
  public Boolean? Subsetted { get; set; }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
}
