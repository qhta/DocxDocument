namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Property Set.
/// </summary>
[OpenXmlType(typeof(DXDD.PropertySet))]
[XmlRoot("PropertySet", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class PropertySet : ModelElement<DXDD.PropertySet>
{
 /// <summary>
 ///   Presentation Element Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PresentationElementId))]
 public string? PresentationElementId { get => _PresentationElementId; set => UpdateField(ref _PresentationElementId, value, nameof(PresentationElementId)); }
 private string? _PresentationElementId;

 /// <summary>
 ///   Presentation Typeface
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PresentationName))]
 public string? PresentationName { get => _PresentationName; set => UpdateField(ref _PresentationName, value, nameof(PresentationName)); }
 private string? _PresentationName;

 /// <summary>
 ///   Presentation Style Label
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PresentationStyleLabel))]
 public string? PresentationStyleLabel { get => _PresentationStyleLabel; set => UpdateField(ref _PresentationStyleLabel, value, nameof(PresentationStyleLabel)); }
 private string? _PresentationStyleLabel;

 /// <summary>
 ///   Presentation Style Index
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PresentationStyleIndex))]
 public Int32? PresentationStyleIndex { get => _PresentationStyleIndex; set => UpdateField(ref _PresentationStyleIndex, value, nameof(PresentationStyleIndex)); }
 private Int32? _PresentationStyleIndex;

 /// <summary>
 ///   Presentation Style Count
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PresentationStyleCount))]
 public Int32? PresentationStyleCount { get => _PresentationStyleCount; set => UpdateField(ref _PresentationStyleCount, value, nameof(PresentationStyleCount)); }
 private Int32? _PresentationStyleCount;

 /// <summary>
 ///   Current Diagram Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.LayoutTypeId))]
 public string? LayoutTypeId { get => _LayoutTypeId; set => UpdateField(ref _LayoutTypeId, value, nameof(LayoutTypeId)); }
 private string? _LayoutTypeId;

 /// <summary>
 ///   Current Diagram Category
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.LayoutCategoryId))]
 public string? LayoutCategoryId { get => _LayoutCategoryId; set => UpdateField(ref _LayoutCategoryId, value, nameof(LayoutCategoryId)); }
 private string? _LayoutCategoryId;

 /// <summary>
 ///   Current Style Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.QuickStyleTypeId))]
 public string? QuickStyleTypeId { get => _QuickStyleTypeId; set => UpdateField(ref _QuickStyleTypeId, value, nameof(QuickStyleTypeId)); }
 private string? _QuickStyleTypeId;

 /// <summary>
 ///   Current Style Category
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.QuickStyleCategoryId))]
 public string? QuickStyleCategoryId { get => _QuickStyleCategoryId; set => UpdateField(ref _QuickStyleCategoryId, value, nameof(QuickStyleCategoryId)); }
 private string? _QuickStyleCategoryId;

 /// <summary>
 ///   Color Transform Type Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.ColorType))]
 public string? ColorType { get => _ColorType; set => UpdateField(ref _ColorType, value, nameof(ColorType)); }
 private string? _ColorType;

 /// <summary>
 ///   Color Transform Category
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.ColorCategoryId))]
 public string? ColorCategoryId { get => _ColorCategoryId; set => UpdateField(ref _ColorCategoryId, value, nameof(ColorCategoryId)); }
 private string? _ColorCategoryId;

 /// <summary>
 ///   Coherent 3D Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.Coherent3D))]
 public bool? Coherent3D { get => _Coherent3D; set => UpdateField(ref _Coherent3D, value, nameof(Coherent3D)); }
 private bool? _Coherent3D;

 /// <summary>
 ///   Placeholder Text
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PlaceholderText))]
 public string? PlaceholderText { get => _PlaceholderText; set => UpdateField(ref _PlaceholderText, value, nameof(PlaceholderText)); }
 private string? _PlaceholderText;

 /// <summary>
 ///   Placeholder
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.Placeholder))]
 public bool? Placeholder { get => _Placeholder; set => UpdateField(ref _Placeholder, value, nameof(Placeholder)); }
 private bool? _Placeholder;

 /// <summary>
 ///   Custom Rotation
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.Rotation))]
 public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }
 private Int32? _Rotation;

 /// <summary>
 ///   Custom Vertical Flip
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.VerticalFlip))]
 public bool? VerticalFlip { get => _VerticalFlip; set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip)); }
 private bool? _VerticalFlip;

 /// <summary>
 ///   Custom Horizontal Flip
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.HorizontalFlip))]
 public bool? HorizontalFlip { get => _HorizontalFlip; set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip)); }
 private bool? _HorizontalFlip;

 /// <summary>
 ///   Fixed Width Override
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.FixedWidthOverride))]
 public Int32? FixedWidthOverride { get => _FixedWidthOverride; set => UpdateField(ref _FixedWidthOverride, value, nameof(FixedWidthOverride)); }
 private Int32? _FixedWidthOverride;

 /// <summary>
 ///   Fixed Height Override
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.FixedHeightOverride))]
 public Int32? FixedHeightOverride { get => _FixedHeightOverride; set => UpdateField(ref _FixedHeightOverride, value, nameof(FixedHeightOverride)); }
 private Int32? _FixedHeightOverride;

 /// <summary>
 ///   Width Scale
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.WidthScale))]
 public Int32? WidthScale { get => _WidthScale; set => UpdateField(ref _WidthScale, value, nameof(WidthScale)); }
 private Int32? _WidthScale;

 /// <summary>
 ///   Height Scale
 /// </summary>
 [OpenXmlElement(typeof(DXDD.Style))]
 public Int32? HightScale { get => _HightScale; set => UpdateField(ref _HightScale, value, nameof(HightScale)); }
 private Int32? _HightScale;

 /// <summary>
 ///   Text Changed
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.TextChanged))]
 public bool? TextChanged { get => _TextChanged; set => UpdateField(ref _TextChanged, value, nameof(TextChanged)); }
 private bool? _TextChanged;

 /// <summary>
 ///   Custom Factor Width
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.FactorWidth))]
 public Int32? FactorWidth { get => _FactorWidth; set => UpdateField(ref _FactorWidth, value, nameof(FactorWidth)); }
 private Int32? _FactorWidth;

 /// <summary>
 ///   Custom Factor Height
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.FactorHeight))]
 public Int32? FactorHeight { get => _FactorHeight; set => UpdateField(ref _FactorHeight, value, nameof(FactorHeight)); }
 private Int32? _FactorHeight;

 /// <summary>
 ///   Neighbor Offset Width
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.NeighborOffsetWidth))]
 public Int32? NeighborOffsetWidth { get => _NeighborOffsetWidth; set => UpdateField(ref _NeighborOffsetWidth, value, nameof(NeighborOffsetWidth)); }
 private Int32? _NeighborOffsetWidth;

 /// <summary>
 ///   Neighbor Offset Height
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.NeighborOffsetHeight))]
 public Int32? NeighborOffsetHeight { get => _NeighborOffsetHeight; set => UpdateField(ref _NeighborOffsetHeight, value, nameof(NeighborOffsetHeight)); }
 private Int32? _NeighborOffsetHeight;

 /// <summary>
 ///   Radius Scale
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.RadiusScale))]
 public Int32? RadiusScale { get => _RadiusScale; set => UpdateField(ref _RadiusScale, value, nameof(RadiusScale)); }
 private Int32? _RadiusScale;

 /// <summary>
 ///   Include Angle Scale
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.IncludeAngleScale))]
 public Int32? IncludeAngleScale { get => _IncludeAngleScale; set => UpdateField(ref _IncludeAngleScale, value, nameof(IncludeAngleScale)); }
 private Int32? _IncludeAngleScale;

 /// <summary>
 ///   Presentation Layout Variables.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.PresentationLayoutVariables))]
 public PresentationLayoutVariables? PresentationLayoutVariables { get => _PresentationLayoutVariables; set => UpdateField(ref _PresentationLayoutVariables, value, nameof(PresentationLayoutVariables)); }
 private PresentationLayoutVariables? _PresentationLayoutVariables;

 /// <summary>
 ///   Shape Style.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PropertySet.Style))]
 public Style? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }
 private Style? _Style;
}