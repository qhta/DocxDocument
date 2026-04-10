namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.NonVisualGroupDrawingShapeProperties))]
[XmlRoot("NonVisualGroupDrawingShapeProperties", Namespace = "DocumentModel.Drawings")]
public abstract partial class NonVisualGroupDrawingShapeProperties<T> : ModelElement<DXOD.NonVisualGroupDrawingShapeProperties>
{
 /// <summary>
 ///   GroupShapeLocks.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualGroupDrawingShapeProperties.GroupShapeLocks))]
 public GroupShapeLocks? GroupShapeLocks { get => _GroupShapeLocks; set => UpdateField(ref _GroupShapeLocks, value, nameof(GroupShapeLocks)); }

 private GroupShapeLocks? _GroupShapeLocks;
 /// <summary>
 ///   NonVisualGroupDrawingShapePropsExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualGroupDrawingShapeProperties.NonVisualGroupDrawingShapePropsExtensionList))]
 public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get => _NonVisualGroupDrawingShapePropsExtensionList; set => UpdateField(ref _NonVisualGroupDrawingShapePropsExtensionList, value, nameof(NonVisualGroupDrawingShapePropsExtensionList)); }

 private NonVisualGroupDrawingShapePropsExtensionList? _NonVisualGroupDrawingShapePropsExtensionList;
}