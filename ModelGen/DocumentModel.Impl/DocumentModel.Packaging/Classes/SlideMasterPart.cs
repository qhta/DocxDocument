namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideMasterPart
/// </summary>
public class SlideMasterPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideMasterPart
{
  public new DocumentFormat.OpenXml.Packaging.SlideMasterPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideMasterPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SlideMasterPartImpl(): base() {}
  
  public SlideMasterPartImpl(DocumentFormat.OpenXml.Packaging.SlideMasterPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartParts of the SlideMasterPart
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
        typeof(DocumentFormat.OpenXml.Packaging.SlideMasterPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
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
        typeof(DocumentFormat.OpenXml.Packaging.SlideMasterPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlideLayoutPart>? SlideLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the SlideParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.UserDefinedTagsPart>? UserDefinedTagsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
