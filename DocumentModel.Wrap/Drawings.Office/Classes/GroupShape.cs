namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public class GroupShape: ModelElement
{
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }

  public GroupShapeProperties? GroupShapeProperties { get; set; }

  public Shape? Shape { get; set; }

  public GroupShape? ChildGroupShape { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}