namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   List of Shape Guides.
/// </summary>
public class ShapeGuideList: ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}