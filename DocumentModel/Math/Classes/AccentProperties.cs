namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Accent Properties.
/// </summary>
public class AccentProperties: ModelElement
{
  /// <summary>
  ///   Accent Character.
  /// </summary>
  public String? AccentChar { get; set; }

  /// <summary>
  ///   Control Properties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}