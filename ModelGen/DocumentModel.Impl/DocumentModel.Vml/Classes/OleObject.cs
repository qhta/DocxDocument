namespace DocumentModel.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public class OleObjectImpl: ModelElementImpl, OleObject
{
  public DocumentFormat.OpenXml.Vml.Office.OleObject? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.OleObject?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public OleKind? Type
  {
    get => (OleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.OleValues?)value;
    }
  }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  public String? ProgId
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public String? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public OleDrawAspectKind? DrawAspect
  {
    get => (OleDrawAspectKind?)OpenXmlElement?.DrawAspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DrawAspect = (DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues?)value;
    }
  }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  public String? ObjectId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public OleUpdateMode? UpdateMode
  {
    get => (OleUpdateMode?)OpenXmlElement?.UpdateMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UpdateMode = (DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues?)value;
    }
  }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  public String? LinkType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public String? LockedField
  {
    get;
    set;
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public String? FieldCodes
  {
    get;
    set;
  }
  
}
