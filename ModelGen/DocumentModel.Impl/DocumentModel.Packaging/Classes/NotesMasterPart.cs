namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NotesMasterPart
/// </summary>
public class NotesMasterPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, NotesMasterPart
{
  /// <summary>
  /// Gets the ChartParts of the NotesMasterPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? CustomXmlParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the NotesMasterPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the NotesMasterPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the NotesMasterPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the NotesMasterPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the NotesMasterPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedControlPersistenceBinaryDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedObjectParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedPackageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the NotesMasterPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? Model3DReferenceRelationshipParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the NotesMasterPart
  /// </summary>
  public OpenXmlPartContainer? UserDefinedTagsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the NotesMasterPart
  /// </summary>
  public VmlDrawingPart? VmlDrawingParts
  {
    get;
    set;
  }
  
}
