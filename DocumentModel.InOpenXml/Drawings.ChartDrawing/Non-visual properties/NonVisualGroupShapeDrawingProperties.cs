namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a group shape in chart drawings, including locking options and extension data for group-level settings.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualGroupShapeDrawingProperties))]
[XmlRoot("NonVisualGroupShapeDrawingProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class NonVisualGroupShapeDrawingProperties : ModelElement<DXD.NonVisualGroupShapeDrawingProperties>
{
 /// <summary>
 /// Specifies locking options that restrict editing or manipulation of the group shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualGroupShapeDrawingProperties.GroupShapeLocks))]
 public GroupShapeLocks? GroupShapeLocks { get => _GroupShapeLocks; set => UpdateField(ref _GroupShapeLocks, value, nameof(GroupShapeLocks)); }

 private GroupShapeLocks? _GroupShapeLocks;
 /// <summary>
 /// Extension list for additional or future non-visual group shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualGroupShapeDrawingProperties.NonVisualGroupDrawingShapePropsExtensionList))]
 public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get => _NonVisualGroupDrawingShapePropsExtensionList; set => UpdateField(ref _NonVisualGroupDrawingShapePropsExtensionList, value, nameof(NonVisualGroupDrawingShapePropsExtensionList)); }

 private NonVisualGroupDrawingShapePropsExtensionList? _NonVisualGroupDrawingShapePropsExtensionList;
}