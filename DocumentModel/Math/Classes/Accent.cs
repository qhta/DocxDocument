namespace DocumentModel.Math;

/// <summary>
///   Accent.
/// </summary>
public class Accent: DMW.ParagraphElement
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