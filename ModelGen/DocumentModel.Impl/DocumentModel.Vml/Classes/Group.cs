namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public partial class GroupImpl: ModelElementImpl, Group
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Group? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Group?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GroupImpl(): base() {}
  
  public GroupImpl(DocumentFormat.OpenXml.Vml.Group openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
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
  /// Shape Styling Properties
  /// </summary>
  public String? Style
  {
    get => (System.String?)OpenXmlElement?.Style?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Style = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public String? Href
  {
    get => (System.String?)OpenXmlElement?.Href?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Href = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public String? Target
  {
    get => (System.String?)OpenXmlElement?.Target?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Target = (System.String?)value;
    }
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public String? Class
  {
    get => (System.String?)OpenXmlElement?.Class?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Class = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public String? Title
  {
    get => (System.String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public String? Alternate
  {
    get => (System.String?)OpenXmlElement?.Alternate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alternate = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public String? CoordinateSize
  {
    get => (System.String?)OpenXmlElement?.CoordinateSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CoordinateSize = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public String? CoordinateOrigin
  {
    get => (System.String?)OpenXmlElement?.CoordinateOrigin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CoordinateOrigin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public String? WrapCoordinates
  {
    get => (System.String?)OpenXmlElement?.WrapCoordinates?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WrapCoordinates = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public Boolean? Print
  {
    get => (System.Boolean?)OpenXmlElement?.Print?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Print = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// spid
  /// </summary>
  public String? OptionalString
  {
    get => (System.String?)OpenXmlElement?.OptionalString?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OptionalString = (System.String?)value;
    }
  }
  
  /// <summary>
  /// oned
  /// </summary>
  public Boolean? Oned
  {
    get => (System.Boolean?)OpenXmlElement?.Oned?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Oned = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// regroupid
  /// </summary>
  public Int32? RegroupId
  {
    get => (System.Int32?)OpenXmlElement?.RegroupId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RegroupId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  public Boolean? DoubleClickNotify
  {
    get => (System.Boolean?)OpenXmlElement?.DoubleClickNotify?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DoubleClickNotify = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// button
  /// </summary>
  public Boolean? Button
  {
    get => (System.Boolean?)OpenXmlElement?.Button?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Button = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// userhidden
  /// </summary>
  public Boolean? UserHidden
  {
    get => (System.Boolean?)OpenXmlElement?.UserHidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserHidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// bullet
  /// </summary>
  public Boolean? Bullet
  {
    get => (System.Boolean?)OpenXmlElement?.Bullet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bullet = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// hr
  /// </summary>
  public Boolean? Horizontal
  {
    get => (System.Boolean?)OpenXmlElement?.Horizontal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Horizontal = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// hrstd
  /// </summary>
  public Boolean? HorizontalStandard
  {
    get => (System.Boolean?)OpenXmlElement?.HorizontalStandard?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalStandard = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  public Boolean? HorizontalNoShade
  {
    get => (System.Boolean?)OpenXmlElement?.HorizontalNoShade?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalNoShade = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// hrpct
  /// </summary>
  public Single? HorizontalPercentage
  {
    get => (System.Single?)OpenXmlElement?.HorizontalPercentage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalPercentage = (System.Single?)value;
    }
  }
  
  /// <summary>
  /// hralign
  /// </summary>
  public DocumentModel.Vml.HorizontalRuleAlignmentKind? HorizontalAlignment
  {
    get => (DocumentModel.Vml.HorizontalRuleAlignmentKind?)OpenXmlElement?.HorizontalAlignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalAlignment = (DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// allowincell
  /// </summary>
  public Boolean? AllowInCell
  {
    get => (System.Boolean?)OpenXmlElement?.AllowInCell?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowInCell = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public Boolean? AllowOverlap
  {
    get => (System.Boolean?)OpenXmlElement?.AllowOverlap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowOverlap = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  public Boolean? UserDrawn
  {
    get => (System.Boolean?)OpenXmlElement?.UserDrawn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserDrawn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  public Int32? DiagramLayout
  {
    get => (System.Int32?)OpenXmlElement?.DiagramLayout?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramLayout = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  public Int32? DiagramNodeKind
  {
    get => (System.Int32?)OpenXmlElement?.DiagramNodeKind?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramNodeKind = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed
  {
    get => (System.Int32?)OpenXmlElement?.DiagramLayoutMostRecentUsed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramLayoutMostRecentUsed = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public DocumentModel.Vml.InsetMarginKind? InsetMode
  {
    get => (DocumentModel.Vml.InsetMarginKind?)OpenXmlElement?.InsetMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetMode = (DocumentFormat.OpenXml.Vml.Office.InsetMarginValues?)value;
    }
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.Base64Binary? Gfxdata
  {
    get
    {
      if (OpenXmlElement?.Gfxdata?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.Gfxdata.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Gfxdata = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Gfxdata = null;
      }
    }
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public DocumentModel.Vml.EditAsKind? EditAs
  {
    get => (DocumentModel.Vml.EditAsKind?)OpenXmlElement?.EditAs?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EditAs = (DocumentFormat.OpenXml.Vml.EditAsValues?)value;
    }
  }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  public String? TableProperties
  {
    get => (System.String?)OpenXmlElement?.TableProperties?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TableProperties = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  public String? TableLimits
  {
    get => (System.String?)OpenXmlElement?.TableLimits?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TableLimits = (System.String?)value;
    }
  }
  
  public DocumentModel.Vml.Group? ChildGroup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
        if (item != null)
          return new DocumentModel.Vml.GroupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.GroupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Shape? Shape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
        if (item != null)
          return new DocumentModel.Vml.ShapeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShapeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Shapetype? Shapetype
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
        if (item != null)
          return new DocumentModel.Vml.ShapetypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShapetypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Arc? Arc
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
        if (item != null)
          return new DocumentModel.Vml.ArcImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ArcImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Curve? Curve
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
        if (item != null)
          return new DocumentModel.Vml.CurveImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.CurveImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.ImageFile? ImageFile
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
        if (item != null)
          return new DocumentModel.Vml.ImageFileImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ImageFileImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Line? Line
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
        if (item != null)
          return new DocumentModel.Vml.LineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.LineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Oval? Oval
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
        if (item != null)
          return new DocumentModel.Vml.OvalImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.OvalImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.PolyLine? PolyLine
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
        if (item != null)
          return new DocumentModel.Vml.PolyLineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.PolyLineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Rectangle? Rectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
        if (item != null)
          return new DocumentModel.Vml.RectangleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.RectangleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.RoundRectangle? RoundRectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
        if (item != null)
          return new DocumentModel.Vml.RoundRectangleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.RoundRectangleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Diagram? Diagram
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
        if (item != null)
          return new DocumentModel.Vml.DiagramImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.DiagramImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Lock? Lock
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
        if (item != null)
          return new DocumentModel.Vml.LockImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.LockImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.ClipPath? ClipPath
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
        if (item != null)
          return new DocumentModel.Vml.ClipPathImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ClipPathImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Vml.TextWrap? TextWrap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
        if (item != null)
          return new DocumentModel.Wordprocessing.Vml.TextWrapImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.Vml.TextWrapImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? AnchorLock
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
