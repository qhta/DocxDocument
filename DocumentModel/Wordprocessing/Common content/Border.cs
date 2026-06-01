namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public class IBorder: ModelElement
{
  /// <summary>
  ///   IBorder IStyle
  /// </summary>
  public BorderKind? Type { get; set; }

  /// <summary>
  ///   IBorder Color
  /// </summary>
  public DM.Color? Color { get; set; }

  /// <summary>
  ///   IBorder Width
  /// </summary>
  public Twips? Width { get; set; }

  /// <summary>
  ///   IBorder Spacing Measurement
  /// </summary>
  public Twips? Space { get; set; }

  /// <summary>
  ///   IBorder Shadow
  /// </summary>
  public bool? Shadow { get; set; }

  /// <summary>
  ///   Create IFrame Effect
  /// </summary>
  public bool? IFrame { get; set; }
}
