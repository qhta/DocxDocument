namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IPoint IList.
/// </summary>
public class PointList: ModelElement
{
  public Collection<IPoint>? IPoints { get; set; }
}
