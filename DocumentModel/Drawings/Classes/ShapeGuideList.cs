namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IList of IShape Guides.
/// </summary>
public class ShapeGuideList: ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}
