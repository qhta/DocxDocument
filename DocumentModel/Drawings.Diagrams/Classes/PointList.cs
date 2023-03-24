namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Point List.
/// </summary>
public class PointList: ModelElement
{
  public Collection<Point>? Points { get; set; }
}