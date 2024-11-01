namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public class ShapeTree: ModelElement
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }

  public GroupShapeProperties? GroupShapeProperties { get; set; }

  public Shape? Shape { get; set; }

  public GroupShape? GroupShape { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}