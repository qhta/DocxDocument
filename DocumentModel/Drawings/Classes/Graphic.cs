namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Graphic Object.
/// </summary>
public class Graphic: ModelElement
{
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  public GraphicData? GraphicData { get; set; }
}