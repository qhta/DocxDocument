namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NotesSlidePart
/// </summary>
public class NotesSlidePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, NotesSlidePart
{
  public new DocumentFormat.OpenXml.Packaging.NotesSlidePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.NotesSlidePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NotesSlidePartImpl(): base() {}
  
  public NotesSlidePartImpl(DocumentFormat.OpenXml.Packaging.NotesSlidePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartParts of the NotesSlidePart
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
        typeof(DocumentFormat.OpenXml.Packaging.NotesSlidePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.CustomXmlPart? CustomXmlParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramColorsPart? DiagramColorsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramDataPart? DiagramDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramStylePart? DiagramStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedObjectPart? EmbeddedObjectParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedPackagePart? EmbeddedPackageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.ExtendedChartPart? ExtendedChartParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ImageParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the NotesSlidePart
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
        typeof(DocumentFormat.OpenXml.Packaging.NotesSlidePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.UserDefinedTagsPart? UserDefinedTagsParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.VmlDrawingPart? VmlDrawingParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
