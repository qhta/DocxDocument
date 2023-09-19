namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type is a supplementary document storage location which stores the definition and content for content that shall be carried with the document for future insertion and/or use, but which shall not be visible within the contents of the main document story.
/// </summary>
public partial class GlossaryDocumentPart
{
  
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? AlternativeFormatImportParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? ChartParts { get; set; }
  
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? DiagramColorsParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? DiagramDataParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? DiagramLayoutDefinitionParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? DiagramPersistLayoutParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? DiagramStyleParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? EmbeddedControlPersistenceParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? EmbeddedObjectParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? EmbeddedPackageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? ExtendedChartParts { get; set; }
  
  
  /// <summary>
  ///   Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? FooterParts { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.GlossaryDocument? GlossaryDocument { get; set; }
  
  
  /// <summary>
  ///   Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? HeaderParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? Model3DReferenceRelationshipParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection? WordprocessingPrinterSettingsParts { get; set; }
  
}
