namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsExPart
/// </summary>
public class WordprocessingCommentsExPart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsExPart
  /// </summary>
  public OpenXmlPartContainer? AlternativeFormatImportParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsEx? CommentsEx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsExPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsExPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsExPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsExPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsExPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsExPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsExPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedObjectParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsExPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedPackageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsExPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsExPart
  /// </summary>
  public OpenXmlPartContainer? Model3DReferenceRelationshipParts
  {
    get;
    set;
  }
  
}
