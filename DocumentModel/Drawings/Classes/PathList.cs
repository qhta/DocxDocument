namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IList of IShape Paths.
/// </summary>
public class PathList: ModelElement
{
  public Collection<Path>? Paths { get; set; }
}
