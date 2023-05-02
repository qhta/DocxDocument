namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   List of Shape Adjust Values.
/// </summary>
public class AdjustValueList: ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}