namespace DocumentModel.Vml;
/// <summary>
///   Shape Layout Properties.
/// </summary>
[OpenXmlType(typeof(DXVO.ShapeLayout))]
public partial class ShapeLayout : ModelElement<DXVO.ShapeLayout>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.Extension))]
 [OpenXmlElement(typeof(DXVO.ShapeLayout))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Shape ID Map.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.ShapeIdMap))]
 [OpenXmlElement(typeof(DXVO.ShapeLayout))]
 public ShapeIdMap? ShapeIdMap { get => _ShapeIdMap; set => UpdateField(ref _ShapeIdMap, value, nameof(ShapeIdMap)); }

 private ShapeIdMap? _ShapeIdMap;
 /// <summary>
 ///   Shape Grouping History.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.RegroupTable))]
 [OpenXmlElement(typeof(DXVO.ShapeLayout))]
 public RegroupTable? RegroupTable { get => _RegroupTable; set => UpdateField(ref _RegroupTable, value, nameof(RegroupTable)); }

 private RegroupTable? _RegroupTable;
 /// <summary>
 ///   Rule Set.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.Rules))]
 [OpenXmlElement(typeof(DXVO.ShapeLayout))]
 public Rules? Rules { get => _Rules; set => UpdateField(ref _Rules, value, nameof(Rules)); }

 private Rules? _Rules;
}