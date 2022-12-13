namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NotesMasterPart
/// </summary>
public class NotesMasterPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, NotesMasterPart
{
  public new DocumentFormat.OpenXml.Packaging.NotesMasterPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.NotesMasterPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NotesMasterPartImpl(): base() {}
  
  public NotesMasterPartImpl(DocumentFormat.OpenXml.Packaging.NotesMasterPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.ChartPart? ChartParts
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
        typeof(DocumentFormat.OpenXml.Packaging.NotesMasterPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.CustomXmlPart? CustomXmlParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.DiagramColorsPart? DiagramColorsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.DiagramDataPart? DiagramDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.DiagramStylePart? DiagramStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedObjectPart? EmbeddedObjectParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedPackagePart? EmbeddedPackageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.ExtendedChartPart? ExtendedChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts
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
        typeof(DocumentFormat.OpenXml.Packaging.NotesMasterPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.UserDefinedTagsPart? UserDefinedTagsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the NotesMasterPart
  /// </summary>
  public DocumentModel.Packaging.VmlDrawingPart? VmlDrawingParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
