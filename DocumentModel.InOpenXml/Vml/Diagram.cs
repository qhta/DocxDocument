namespace DocumentModel.Vml;
/// <summary>
///   VML Diagram.
/// </summary>
[OpenXmlType(typeof(DXVO.Diagram))]
public partial class Diagram : ModelElement<DXVO.Diagram>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.Extension))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Diagram Style Options
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.Style))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public Int64? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private Int64? _Style;
 /// <summary>
 ///   Diagram Automatic Format
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.AutoFormat))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public bool? AutoFormat { get => _AutoFormat; set => UpdateField(ref _AutoFormat, value, nameof(AutoFormat)); }

 private bool? _AutoFormat;
 /// <summary>
 ///   Diagram Reverse Direction
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.Reverse))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public bool? Reverse { get => _Reverse; set => UpdateField(ref _Reverse, value, nameof(Reverse)); }

 private bool? _Reverse;
 /// <summary>
 ///   Diagram Automatic Layout
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.AutoLayout))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public bool? AutoLayout { get => _AutoLayout; set => UpdateField(ref _AutoLayout, value, nameof(AutoLayout)); }

 private bool? _AutoLayout;
 /// <summary>
 ///   Diagram Layout X Scale
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.ScaleX))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public Int64? ScaleX { get => _ScaleX; set => UpdateField(ref _ScaleX, value, nameof(ScaleX)); }

 private Int64? _ScaleX;
 /// <summary>
 ///   Diagram Layout Y Scale
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.ScaleY))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public Int64? ScaleY { get => _ScaleY; set => UpdateField(ref _ScaleY, value, nameof(ScaleY)); }

 private Int64? _ScaleY;
 /// <summary>
 ///   Diagram Font Size
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.FontSize))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public Int64? FontSize { get => _FontSize; set => UpdateField(ref _FontSize, value, nameof(FontSize)); }

 private Int64? _FontSize;
 /// <summary>
 ///   Diagram Layout Extents
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.ConstrainBounds))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public string? ConstrainBounds { get => _ConstrainBounds; set => UpdateField(ref _ConstrainBounds, value, nameof(ConstrainBounds)); }

 private string? _ConstrainBounds;
 /// <summary>
 ///   Diagram Base Font Size
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.BaseTextScale))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public Int64? BaseTextScale { get => _BaseTextScale; set => UpdateField(ref _BaseTextScale, value, nameof(BaseTextScale)); }

 private Int64? _BaseTextScale;
 /// <summary>
 ///   Diagram Relationship Table.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Diagram.RelationTable))]
 [OpenXmlElement(typeof(DXVO.Diagram))]
 public RelationTable? RelationTable { get => _RelationTable; set => UpdateField(ref _RelationTable, value, nameof(RelationTable)); }

 private RelationTable? _RelationTable;
}