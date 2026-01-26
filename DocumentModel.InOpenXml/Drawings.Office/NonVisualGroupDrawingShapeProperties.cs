namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.NonVisualGroupDrawingShapeProperties))]
public partial class NonVisualGroupDrawingShapeProperties : ModelElement<DXOD.NonVisualGroupDrawingShapeProperties>
{
 /// <summary>
 ///   GroupShapeLocks.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualGroupDrawingShapeProperties.GroupShapeLocks))]
 /// <summary>
 ///   GroupShapeLocks.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualGroupDrawingShapeProperties))]
 public GroupShapeLocks? GroupShapeLocks { get => _GroupShapeLocks; set => UpdateField(ref _GroupShapeLocks, value, nameof(GroupShapeLocks)); }

 private GroupShapeLocks? _GroupShapeLocks;
 /// <summary>
 ///   NonVisualGroupDrawingShapePropsExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualGroupDrawingShapeProperties.NonVisualGroupDrawingShapePropsExtensionList))]
 /// <summary>
 ///   NonVisualGroupDrawingShapePropsExtensionList.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualGroupDrawingShapeProperties))]
 public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get => _NonVisualGroupDrawingShapePropsExtensionList; set => UpdateField(ref _NonVisualGroupDrawingShapePropsExtensionList, value, nameof(NonVisualGroupDrawingShapePropsExtensionList)); }

 private NonVisualGroupDrawingShapePropsExtensionList? _NonVisualGroupDrawingShapePropsExtensionList;
}