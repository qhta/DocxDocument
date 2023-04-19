namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public class Border: ModelElement
{
  /// <summary>
  ///   Border Style
  /// </summary>
  public BorderKind? Type { get; set; }

  /// <summary>
  ///   Border Color
  /// </summary>
  public Color? Color { get; set; }

  /// <summary>
  ///   Border Width
  /// </summary>
  public Twips? Width { get; set; }

  /// <summary>
  ///   Border Spacing Measurement
  /// </summary>
  public Twips? Space { get; set; }

  /// <summary>
  ///   Border Shadow
  /// </summary>
  public bool? Shadow { get; set; }

  /// <summary>
  ///   Create Frame Effect
  /// </summary>
  public bool? Frame { get; set; }
}