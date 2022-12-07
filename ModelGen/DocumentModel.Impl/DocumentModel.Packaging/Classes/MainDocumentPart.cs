namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
public class MainDocumentPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, MainDocumentPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? AlternativeFormatImportParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? CustomXmlParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedObjectParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedPackageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public FooterPart? FooterParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public HeaderPart? HeaderParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? Model3DReferenceRelationshipParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public OpenXmlPartContainer? WordprocessingPrinterSettingsParts
  {
    get;
    set;
  }
  
}
