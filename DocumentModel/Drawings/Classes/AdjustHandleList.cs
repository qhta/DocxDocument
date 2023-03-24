namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   List of Shape Adjust Handles.
/// </summary>
public class AdjustHandleList: ModelElement
{
  public AdjustHandleXY? AdjustHandleXY { get; set; }

  public AdjustHandlePolar? AdjustHandlePolar { get; set; }
}