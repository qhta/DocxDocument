namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsIdsPart
/// </summary>
public class WordprocessingCommentsIdsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordprocessingCommentsIdsPart
{
  public new DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WordprocessingCommentsIdsPartImpl(): base() {}
  
  public WordprocessingCommentsIdsPartImpl(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public AlternativeFormatImportPart? AlternativeFormatImportParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsIds? CommentsIds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingCommentsIdsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
