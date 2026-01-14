namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents an identified relationship type in a WordprocessingML document.
  /// This interface provides a property for the relationship ID, enabling advanced linking and referencing of document parts, external files, or resources within the document structure.
  /// </summary>
  public class RelationshipType: CollectionItem
  {
    
    /// <summary>
    /// Relationship ID referencing the associated part or resource.
    /// </summary>
    public string? Id { get; set; }
  }