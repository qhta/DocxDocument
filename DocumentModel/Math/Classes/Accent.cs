using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   Accent.
/// </summary>
public class Accent: ICommonMathElement
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