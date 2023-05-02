namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ColorsType Class.
/// </summary>
public class ColorsType: ModelElement
{
  /// <summary>
  ///   Color Application Method Type
  /// </summary>
  public ColorApplicationMethodKind? Method { get; set; }

  /// <summary>
  ///   Hue Direction
  /// </summary>
  public HueDirectionKind? HueDirection { get; set; }
}