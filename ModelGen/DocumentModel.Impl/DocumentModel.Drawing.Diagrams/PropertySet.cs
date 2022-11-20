namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Property Set.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPresentationLayoutVariables))]
public class PropertySet: IPropertySet
{
  /// <summary>
  /// Presentation Element Identifier
  /// </summary>
  public string? PresentationElementId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Presentation Name
  /// </summary>
  public string? PresentationName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Presentation Style Label
  /// </summary>
  public string? PresentationStyleLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Presentation Style Index
  /// </summary>
  public int? PresentationStyleIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Presentation Style Count
  /// </summary>
  public int? PresentationStyleCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// Current Diagram Type
  /// </summary>
  public string? LayoutTypeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Current Diagram Category
  /// </summary>
  public string? LayoutCategoryId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Current Style Type
  /// </summary>
  public string? QuickStyleTypeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Current Style Category
  /// </summary>
  public string? QuickStyleCategoryId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color Transform Type Identifier
  /// </summary>
  public string? ColorType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color Transform Category
  /// </summary>
  public string? ColorCategoryId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coherent 3D Behavior
  /// </summary>
  public bool? Coherent3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Placeholder Text
  /// </summary>
  public string? PlaceholderText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Placeholder
  /// </summary>
  public bool? Placeholder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Rotation
  /// </summary>
  public int? Rotation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Vertical Flip
  /// </summary>
  public bool? VerticalFlip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Horizontal Flip
  /// </summary>
  public bool? HorizontalFlip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fixed Width Override
  /// </summary>
  public int? FixedWidthOverride
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fixed Height Override
  /// </summary>
  public int? FixedHeightOverride
  {
    get;
    set;
  }
  
  /// <summary>
  /// Width Scale
  /// </summary>
  public int? WidthScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Height Scale
  /// </summary>
  public int? HightScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Changed
  /// </summary>
  public bool? TextChanged
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Factor Width
  /// </summary>
  public int? FactorWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Factor Height
  /// </summary>
  public int? FactorHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Neighbor Offset Width
  /// </summary>
  public int? NeighborOffsetWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Neighbor Offset Height
  /// </summary>
  public int? NeighborOffsetHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Radius Scale
  /// </summary>
  public int? RadiusScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Angle Scale
  /// </summary>
  public int? IncludeAngleScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  public IPresentationLayoutVariables? PresentationLayoutVariables
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IStyle? Style
  {
    get;
    set;
  }
  
}
