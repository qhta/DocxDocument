namespace DocumentModel.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public partial class OleObjectImpl: ModelElementImpl, OleObject
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.OleObject? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.OleObject?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public OleObjectImpl(): base() {}
  
  public OleObjectImpl(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public DocumentModel.Vml.OleKind? Type
  {
    get => (DocumentModel.Vml.OleKind?)OpenXmlElement?.Type?.Value;
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
    get => (System.String?)OpenXmlElement?.ProgId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ProgId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public String? ShapeId
  {
    get => (System.String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public DocumentModel.Vml.OleDrawAspectKind? DrawAspect
  {
    get => (DocumentModel.Vml.OleDrawAspectKind?)OpenXmlElement?.DrawAspect?.Value;
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
    get => (System.String?)OpenXmlElement?.ObjectId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ObjectId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public DocumentModel.Vml.OleUpdateMode? UpdateMode
  {
    get => (DocumentModel.Vml.OleUpdateMode?)OpenXmlElement?.UpdateMode?.Value;
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
    get => (System.String?)OpenXmlElement?.LinkType?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LinkType != null)
        {
          if (value is not null)
            OpenXmlElement.LinkType.Text = value;
          else
            OpenXmlElement.LinkType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LinkType = new DocumentFormat.OpenXml.Vml.Office.LinkType{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public String? LockedField
  {
    get => (System.String?)OpenXmlElement?.LockedField?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LockedField != null)
        {
          if (value is not null)
            OpenXmlElement.LockedField.Text = value;
          else
            OpenXmlElement.LockedField = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LockedField = new DocumentFormat.OpenXml.Vml.Office.LockedField{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public String? FieldCodes
  {
    get => (System.String?)OpenXmlElement?.FieldCodes?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FieldCodes != null)
        {
          if (value is not null)
            OpenXmlElement.FieldCodes.Text = value;
          else
            OpenXmlElement.FieldCodes = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FieldCodes = new DocumentFormat.OpenXml.Vml.Office.FieldCodes{ Text = value };
        }
      }
    }
  }
  
}
