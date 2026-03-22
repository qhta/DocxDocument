namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a type definition for a group of drawing elements in a Wordprocessing document.
/// This class provides access to non-visual properties and group properties, enabling configuration and management of grouped graphical content.
/// </summary>
[OpenXmlType(typeof(DXO10WDG.WordprocessingGroupType))]
public abstract partial class WordprocessingGroupType<T> : ModelElement<T> where T : DXO10WDG.WordprocessingGroupType
{
 /// <summary>
 /// Non-visual properties for the group type, including identifiers, names, and descriptive information.
 /// </summary>
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }
 private NonVisualDrawingProperties? _NonVisualDrawingProperties;
 /// <summary>
 /// Non-visual properties specific to group drawing shapes, such as locking and extension settings.
 /// </summary>
 public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get => _NonVisualGroupDrawingShapeProperties; set => UpdateField(ref _NonVisualGroupDrawingShapeProperties, value, nameof(NonVisualGroupDrawingShapeProperties)); }
 private NonVisualGroupDrawingShapeProperties? _NonVisualGroupDrawingShapeProperties;
 /// <summary>
 /// Properties for the group shape, including layout, transformation, and grouping behavior.
 /// </summary>
 public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }
 private GroupShapeProperties? _GroupShapeProperties;
}