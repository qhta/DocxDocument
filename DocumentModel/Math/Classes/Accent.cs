using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Accent.
/// </summary>
public class Accent: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Accent Properties.
  /// </summary>
  public AccentProperties? AccentProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}