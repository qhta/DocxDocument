namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a type definition for a group of drawing elements in a Wordprocessing document.
/// This interface provides access to non-visual properties and group properties, enabling configuration and management of grouped graphical content.
/// </summary>
public interface WordprocessingGroupType
{
  /// <summary>
  /// Non-visual properties for the group type, including identifiers, names, and descriptive information.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual properties specific to group drawing shapes, such as locking and extension settings.
  /// </summary>
  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }

  /// <summary>
  /// Properties for the group shape, including layout, transformation, and grouping behavior.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get; set; }
}