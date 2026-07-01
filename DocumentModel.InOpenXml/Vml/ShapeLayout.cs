namespace DocumentModel.Vml;
/// <summary>
///   Shape Layout Properties.
/// </summary>
[OpenXmlType(typeof(DXVO.ShapeLayout))]
[DataContract]
[XmlRoot("ShapeLayout", Namespace = "DocumentModel.Vml")]
public partial class ShapeLayout : ModelElement<DXVO.ShapeLayout>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.Extension))]
 public ExtensionHandlingBehavior? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }
 private ExtensionHandlingBehavior? _Extension;

 /// <summary>
 ///   Shape ID Map.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.ShapeIdMap))]
 public ShapeIdMap? ShapeIdMap { get => _ShapeIdMap; set => UpdateField(ref _ShapeIdMap, value, nameof(ShapeIdMap)); }
 private ShapeIdMap? _ShapeIdMap;

 /// <summary>
 ///   Shape Grouping History.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.RegroupTable))]
 public RegroupTable? RegroupTable { get => _RegroupTable; set => UpdateField(ref _RegroupTable, value, nameof(RegroupTable)); }
 private RegroupTable? _RegroupTable;

 /// <summary>
 ///   Rule Set.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ShapeLayout.Rules))]
 public Rules? Rules { get => _Rules; set => UpdateField(ref _Rules, value, nameof(Rules)); }
 private Rules? _Rules;
}