namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IClipPath))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IDiagram))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ILock))]
[ChildElementInfo(typeof(DocumentModel.Vml.IArc))]
[ChildElementInfo(typeof(DocumentModel.Vml.ICurve))]
[ChildElementInfo(typeof(DocumentModel.Vml.IGroup))]
[ChildElementInfo(typeof(DocumentModel.Vml.IImageFile))]
[ChildElementInfo(typeof(DocumentModel.Vml.ILine))]
[ChildElementInfo(typeof(DocumentModel.Vml.IOval))]
[ChildElementInfo(typeof(DocumentModel.Vml.IPolyLine))]
[ChildElementInfo(typeof(DocumentModel.Vml.IRectangle))]
[ChildElementInfo(typeof(DocumentModel.Vml.IRoundRectangle))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShape))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShapetype))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.IAnchorLock))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.ITextWrap))]
[ChildElementInfo(typeof(DocumentModel.Vml.Spreadsheet.IClientData))]
public class Group: IGroup
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public string? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public string? Href
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public string? Target
  {
    get;
    set;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public string? Class
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public string? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public string? Alternate
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public string? CoordinateSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public string? CoordinateOrigin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public string? WrapCoordinates
  {
    get;
    set;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public ITrueFalseValue? Print
  {
    get;
    set;
  }
  
  /// <summary>
  /// spid
  /// </summary>
  public string? OptionalString
  {
    get;
    set;
  }
  
  /// <summary>
  /// oned
  /// </summary>
  public ITrueFalseValue? Oned
  {
    get;
    set;
  }
  
  /// <summary>
  /// regroupid
  /// </summary>
  public int? RegroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  public ITrueFalseValue? DoubleClickNotify
  {
    get;
    set;
  }
  
  /// <summary>
  /// button
  /// </summary>
  public ITrueFalseValue? Button
  {
    get;
    set;
  }
  
  /// <summary>
  /// userhidden
  /// </summary>
  public ITrueFalseValue? UserHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// bullet
  /// </summary>
  public ITrueFalseValue? Bullet
  {
    get;
    set;
  }
  
  /// <summary>
  /// hr
  /// </summary>
  public ITrueFalseValue? Horizontal
  {
    get;
    set;
  }
  
  /// <summary>
  /// hrstd
  /// </summary>
  public ITrueFalseValue? HorizontalStandard
  {
    get;
    set;
  }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  public ITrueFalseValue? HorizontalNoShade
  {
    get;
    set;
  }
  
  /// <summary>
  /// hrpct
  /// </summary>
  public float? HorizontalPercentage
  {
    get;
    set;
  }
  
  /// <summary>
  /// hralign
  /// </summary>
  public HorizontalRuleAlignmentValues? HorizontalAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// allowincell
  /// </summary>
  public ITrueFalseValue? AllowInCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public ITrueFalseValue? AllowOverlap
  {
    get;
    set;
  }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  public ITrueFalseValue? UserDrawn
  {
    get;
    set;
  }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  public int? DiagramLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  public int? DiagramNodeKind
  {
    get;
    set;
  }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  public int? DiagramLayoutMostRecentUsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public InsetMarginValues? InsetMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public IBase64BinaryValue? Gfxdata
  {
    get;
    set;
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public DocumentModel.Vml.EditAsValues? EditAs
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  public string? TableProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  public string? TableLimits
  {
    get;
    set;
  }
  
}
