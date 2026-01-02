namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the BorderType Class.
/// </summary>
public interface IBorder: IModelElement
{
  /// <summary>
  ///   Border Style
  /// </summary>
  public BorderKind? Type { get; set; }
  /// <summary>
  ///   Border Color
  /// </summary>
  public IColor? Color { get; set; }
  /// <summary>
  ///   Border Width
  /// </summary>
  public ITwips? Width { get; set; }
  /// <summary>
  ///   Border Spacing Measurement
  /// </summary>
  public ITwips? Space { get; set; }
  /// <summary>
  ///   Border Shadow
  /// </summary>
  public bool? Shadow { get; set; }
  /// <summary>
  ///   Has Frame Effect
  /// </summary>
  public bool? Frame { get; set; }
}