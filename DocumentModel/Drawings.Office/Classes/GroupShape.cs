namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public record GroupShape
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }

  public GroupShapeProperties? GroupShapeProperties { get; set; }

  public Shape? Shape { get; set; }

  public GroupShape? ChildGroupShape { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}