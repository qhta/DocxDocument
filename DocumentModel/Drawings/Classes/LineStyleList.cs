namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Line Style List.
/// </summary>
public class LineStyleList: ModelElement
{
  public LineProperties? Outline { get; set; }
}