namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Effect Style.
/// </summary>
public class EffectStyle: ModelElement
{
  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Scene3DType? Scene3DType { get; set; }

  public Shape3DType? Shape3DType { get; set; }
}