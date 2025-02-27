namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Group Shape Properties.
/// </summary>
public class GroupShapeProperties: ModelElement
{
  /// <summary>
  ///   Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   2D Transform for Grouped Objects.
  /// </summary>
  public TransformGroup? TransformGroup { get; set; }

  public Fill? Fill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Scene3DType? Scene3DType { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}