namespace DocumentModel.Packaging;

/// <summary>
/// Defines the GlossaryDocumentPart
/// </summary>
public class GlossaryDocumentPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, GlossaryDocumentPart
{
  public new DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GlossaryDocumentPartImpl(): base() {}
  
  public GlossaryDocumentPartImpl(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.FooterPart>? FooterParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.GlossaryDocument? GlossaryDocument
  {
    get
    {
      if (OpenXmlElement?.GlossaryDocument != null)
        return new DocumentModel.Wordprocessing.GlossaryDocumentImpl(OpenXmlElement.GlossaryDocument);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.GlossaryDocumentImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.GlossaryDocument = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.HeaderPart>? HeaderParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
