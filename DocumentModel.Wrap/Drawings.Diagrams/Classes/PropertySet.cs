namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Property Set.
/// </summary>
public class PropertySet: ModelElement
{
  /// <summary>
  ///   Presentation Element Identifier
  /// </summary>
  public string? PresentationElementId { get; set; }

  /// <summary>
  ///   Presentation Name
  /// </summary>
  public string? PresentationName { get; set; }

  /// <summary>
  ///   Presentation Style Label
  /// </summary>
  public string? PresentationStyleLabel { get; set; }

  /// <summary>
  ///   Presentation Style Index
  /// </summary>
  public Int32? PresentationStyleIndex { get; set; }

  /// <summary>
  ///   Presentation Style Count
  /// </summary>
  public Int32? PresentationStyleCount { get; set; }

  /// <summary>
  ///   Current Diagram Type
  /// </summary>
  public string? LayoutTypeId { get; set; }

  /// <summary>
  ///   Current Diagram Category
  /// </summary>
  public string? LayoutCategoryId { get; set; }

  /// <summary>
  ///   Current Style Type
  /// </summary>
  public string? QuickStyleTypeId { get; set; }

  /// <summary>
  ///   Current Style Category
  /// </summary>
  public string? QuickStyleCategoryId { get; set; }

  /// <summary>
  ///   Color Transform Type Identifier
  /// </summary>
  public string? ColorType { get; set; }

  /// <summary>
  ///   Color Transform Category
  /// </summary>
  public string? ColorCategoryId { get; set; }

  /// <summary>
  ///   Coherent 3D Behavior
  /// </summary>
  public bool? Coherent3D { get; set; }

  /// <summary>
  ///   Placeholder Text
  /// </summary>
  public string? PlaceholderText { get; set; }

  /// <summary>
  ///   Placeholder
  /// </summary>
  public bool? Placeholder { get; set; }

  /// <summary>
  ///   Custom Rotation
  /// </summary>
  public Int32? Rotation { get; set; }

  /// <summary>
  ///   Custom Vertical Flip
  /// </summary>
  public bool? VerticalFlip { get; set; }

  /// <summary>
  ///   Custom Horizontal Flip
  /// </summary>
  public bool? HorizontalFlip { get; set; }

  /// <summary>
  ///   Fixed Width Override
  /// </summary>
  public Int32? FixedWidthOverride { get; set; }

  /// <summary>
  ///   Fixed Height Override
  /// </summary>
  public Int32? FixedHeightOverride { get; set; }

  /// <summary>
  ///   Width Scale
  /// </summary>
  public Int32? WidthScale { get; set; }

  /// <summary>
  ///   Height Scale
  /// </summary>
  public Int32? HightScale { get; set; }

  /// <summary>
  ///   Text Changed
  /// </summary>
  public bool? TextChanged { get; set; }

  /// <summary>
  ///   Custom Factor Width
  /// </summary>
  public Int32? FactorWidth { get; set; }

  /// <summary>
  ///   Custom Factor Height
  /// </summary>
  public Int32? FactorHeight { get; set; }

  /// <summary>
  ///   Neighbor Offset Width
  /// </summary>
  public Int32? NeighborOffsetWidth { get; set; }

  /// <summary>
  ///   Neighbor Offset Height
  /// </summary>
  public Int32? NeighborOffsetHeight { get; set; }

  /// <summary>
  ///   Radius Scale
  /// </summary>
  public Int32? RadiusScale { get; set; }

  /// <summary>
  ///   Include Angle Scale
  /// </summary>
  public Int32? IncludeAngleScale { get; set; }

  /// <summary>
  ///   Presentation Layout Variables.
  /// </summary>
  public PresentationLayoutVariables? PresentationLayoutVariables { get; set; }

  /// <summary>
  ///   Shape Style.
  /// </summary>
  public Style? Style { get; set; }
}