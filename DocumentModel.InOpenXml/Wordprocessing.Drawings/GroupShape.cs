namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a group shape element within a Wordprocessing document drawing group.
/// This interface provides access to non-visual properties, group properties, child shapes, graphic frames, pictures, and extension data, enabling hierarchical organization and advanced layout of graphical content.
/// </summary>
public interface GroupShape : DMD.IOfficeArtExtendableElement
{
  /// <summary>
  /// Non-visual properties for the group shape, including identifiers, names, and descriptive information.
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

  /// <summary>
  /// A shape element contained within the group, representing an individual graphical object.
  /// </summary>
  public Shape? WordprocessingShape { get; set; }

  /// <summary>
  /// A child group shape element, enabling nested grouping of shapes for hierarchical organization.
  /// </summary>
  public GroupShape? ChildGroupShape { get; set; }

  /// <summary>
  /// A graphic frame element contained within the group, used for advanced graphical content such as images, charts, or diagrams.
  /// </summary>
  public GraphicFrame? GraphicFrame { get; set; }
  /// <summary>
  /// A picture element contained within the group, representing an embedded image.
  /// </summary>
}