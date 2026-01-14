using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;

  /// <summary>
  /// Represents a content part in a WordprocessingML document, providing properties for visual and non-visual shape properties, transformation, and extension data.
  /// This interface enables advanced configuration and management of embedded or linked content parts, supporting black-and-white rendering, relationship references, and OfficeArt extensions.
  /// </summary>
  public interface ContentPart : IOfficeArtExtendableElement
  {
    
    /// <summary>
    /// Black-and-white rendering mode for the content part.
    /// </summary>
    public BlackWhiteMode? BlackWhiteMode { get; set; }
    
    /// <summary>
    /// Relationship ID referencing the associated content part.
    /// </summary>
    public string? RelationshipId { get; set; }
    
    /// <summary>
    /// Non-visual shape properties for the content part, specifying metadata and configuration not directly affecting rendering.
    /// </summary>
    public DMWD.WordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get; set; }
    
    /// <summary>
    /// 2D transformation properties for the content part, specifying scaling, rotation, and translation.
    /// </summary>
    public Transform2D? Transform2D { get; set; }
  }