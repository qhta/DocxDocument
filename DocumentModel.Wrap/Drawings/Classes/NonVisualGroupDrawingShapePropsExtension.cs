namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public class NonVisualGroupDrawingShapePropsExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
}