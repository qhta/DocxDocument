namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the EffectContainerType Class.
/// </summary>
public class EffectContainerType: ModelElement
{
  /// <summary>
  ///   Effect Container Type
  /// </summary>
  public EffectContainerKind? Type { get; set; }

  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }
}