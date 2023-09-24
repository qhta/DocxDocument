namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the endnotes for the document.
/// </summary>
public partial class EndnotesPart
{
  
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the EndnotesPart
  /// </summary>
  public Collection? AlternativeFormatImportParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ChartParts of the EndnotesPart
  /// </summary>
  public Collection? ChartParts { get; set; }
  
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramColorsParts of the EndnotesPart
  /// </summary>
  public Collection? DiagramColorsParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramDataParts of the EndnotesPart
  /// </summary>
  public Collection? DiagramDataParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the EndnotesPart
  /// </summary>
  public Collection? DiagramLayoutDefinitionParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the EndnotesPart
  /// </summary>
  public Collection? DiagramPersistLayoutParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramStyleParts of the EndnotesPart
  /// </summary>
  public Collection? DiagramStyleParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the EndnotesPart
  /// </summary>
  public Collection? EmbeddedControlPersistenceParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the EndnotesPart
  /// </summary>
  public Collection? EmbeddedObjectParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the EndnotesPart
  /// </summary>
  public Collection? EmbeddedPackageParts { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Endnotes? Endnotes { get; set; }
  
  
  /// <summary>
  ///   Gets the ExtendedChartParts of the EndnotesPart
  /// </summary>
  public Collection? ExtendedChartParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the EndnotesPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the EndnotesPart
  /// </summary>
  public Collection? Model3DReferenceRelationshipParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
