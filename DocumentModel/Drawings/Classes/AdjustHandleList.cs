namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IList of IShape Adjust Handles.
/// </summary>
public class AdjustHandleList: ModelElement
{
  public AdjustHandleXY? AdjustHandleXY { get; set; }

  public AdjustHandlePolar? AdjustHandlePolar { get; set; }
}
