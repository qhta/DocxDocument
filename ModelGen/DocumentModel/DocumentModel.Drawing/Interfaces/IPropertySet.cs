namespace DocumentModel.Drawing;

/// <summary>
/// Property Set.
/// </summary>
public interface IPropertySet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Presentation Element Identifier
  /// </summary>
  public System.String? PresentationElementId { get ; set; }
  
  /// <summary>
  /// Presentation Name
  /// </summary>
  public System.String? PresentationName { get ; set; }
  
  /// <summary>
  /// Presentation Style Label
  /// </summary>
  public System.String? PresentationStyleLabel { get ; set; }
  
  /// <summary>
  /// Presentation Style Index
  /// </summary>
  public System.Int32? PresentationStyleIndex { get ; set; }
  
  /// <summary>
  /// Presentation Style Count
  /// </summary>
  public System.Int32? PresentationStyleCount { get ; set; }
  
  /// <summary>
  /// Current Diagram Type
  /// </summary>
  public System.String? LayoutTypeId { get ; set; }
  
  /// <summary>
  /// Current Diagram Category
  /// </summary>
  public System.String? LayoutCategoryId { get ; set; }
  
  /// <summary>
  /// Current Style Type
  /// </summary>
  public System.String? QuickStyleTypeId { get ; set; }
  
  /// <summary>
  /// Current Style Category
  /// </summary>
  public System.String? QuickStyleCategoryId { get ; set; }
  
  /// <summary>
  /// Color Transform Type Identifier
  /// </summary>
  public System.String? ColorType { get ; set; }
  
  /// <summary>
  /// Color Transform Category
  /// </summary>
  public System.String? ColorCategoryId { get ; set; }
  
  /// <summary>
  /// Coherent 3D Behavior
  /// </summary>
  public System.Boolean? Coherent3D { get ; set; }
  
  /// <summary>
  /// Placeholder Text
  /// </summary>
  public System.String? PlaceholderText { get ; set; }
  
  /// <summary>
  /// Placeholder
  /// </summary>
  public System.Boolean? Placeholder { get ; set; }
  
  /// <summary>
  /// Custom Rotation
  /// </summary>
  public System.Int32? Rotation { get ; set; }
  
  /// <summary>
  /// Custom Vertical Flip
  /// </summary>
  public System.Boolean? VerticalFlip { get ; set; }
  
  /// <summary>
  /// Custom Horizontal Flip
  /// </summary>
  public System.Boolean? HorizontalFlip { get ; set; }
  
  /// <summary>
  /// Fixed Width Override
  /// </summary>
  public System.Int32? FixedWidthOverride { get ; set; }
  
  /// <summary>
  /// Fixed Height Override
  /// </summary>
  public System.Int32? FixedHeightOverride { get ; set; }
  
  /// <summary>
  /// Width Scale
  /// </summary>
  public System.Int32? WidthScale { get ; set; }
  
  /// <summary>
  /// Height Scale
  /// </summary>
  public System.Int32? HightScale { get ; set; }
  
  /// <summary>
  /// Text Changed
  /// </summary>
  public System.Boolean? TextChanged { get ; set; }
  
  /// <summary>
  /// Custom Factor Width
  /// </summary>
  public System.Int32? FactorWidth { get ; set; }
  
  /// <summary>
  /// Custom Factor Height
  /// </summary>
  public System.Int32? FactorHeight { get ; set; }
  
  /// <summary>
  /// Neighbor Offset Width
  /// </summary>
  public System.Int32? NeighborOffsetWidth { get ; set; }
  
  /// <summary>
  /// Neighbor Offset Height
  /// </summary>
  public System.Int32? NeighborOffsetHeight { get ; set; }
  
  /// <summary>
  /// Radius Scale
  /// </summary>
  public System.Int32? RadiusScale { get ; set; }
  
  /// <summary>
  /// Include Angle Scale
  /// </summary>
  public System.Int32? IncludeAngleScale { get ; set; }
  
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  public DocumentModel.Drawing.IPresentationLayoutVariables? PresentationLayoutVariables { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.IStyle? Style { get ; set; }
  
}
