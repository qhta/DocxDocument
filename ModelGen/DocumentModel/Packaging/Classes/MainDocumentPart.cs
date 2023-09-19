namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the body of the document.
/// </summary>
public partial class MainDocumentPart
{
  
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public Collection? AlternativeFormatImportParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public Collection? ChartParts { get; set; }
  
  
  /// <summary>
  ///   Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public Collection? CustomXmlParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public Collection? DiagramColorsParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public Collection? DiagramDataParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public Collection? DiagramLayoutDefinitionParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public Collection? DiagramPersistLayoutParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public Collection? DiagramStyleParts { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public Collection? EmbeddedControlPersistenceParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public Collection? EmbeddedObjectParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public Collection? EmbeddedPackageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public Collection? ExtendedChartParts { get; set; }
  
  
  /// <summary>
  ///   Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public Collection? FooterParts { get; set; }
  
  
  /// <summary>
  ///   Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public Collection? HeaderParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public Collection? Model3DReferenceRelationshipParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public Collection? WordprocessingPrinterSettingsParts { get; set; }
  
}
