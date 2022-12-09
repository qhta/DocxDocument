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
    get => (String?)OpenXmlElement?.ProgId?.Value;
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
    get => (String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
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
    get => (String?)OpenXmlElement?.ObjectId?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LinkType>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LinkType>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Vml.Office.LinkType{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public String? LockedField
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LockedField>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LockedField>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Vml.Office.LockedField{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public String? FieldCodes
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FieldCodes>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FieldCodes>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Vml.Office.FieldCodes{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
