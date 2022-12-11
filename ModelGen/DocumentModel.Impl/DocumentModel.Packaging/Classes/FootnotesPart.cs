namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FootnotesPart
/// </summary>
public class FootnotesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, FootnotesPart
{
  public new DocumentFormat.OpenXml.Packaging.FootnotesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.FootnotesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FootnotesPartImpl(): base() {}
  
  public FootnotesPartImpl(DocumentFormat.OpenXml.Packaging.FootnotesPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the FootnotesPart
  /// </summary>
  public AlternativeFormatImportPart? AlternativeFormatImportParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ChartParts of the FootnotesPart
  /// </summary>
  public ChartPart? ChartParts
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
        typeof(DocumentFormat.OpenXml.Packaging.FootnotesPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the FootnotesPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the FootnotesPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the FootnotesPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the FootnotesPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the FootnotesPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the FootnotesPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the FootnotesPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the FootnotesPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the FootnotesPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Footnotes? Footnotes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the FootnotesPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the FootnotesPart
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
        typeof(DocumentFormat.OpenXml.Packaging.FootnotesPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
