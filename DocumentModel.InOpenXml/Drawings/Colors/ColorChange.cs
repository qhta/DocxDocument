namespace DocumentModel.Drawings;

/// <summary>
/// Color change effect for drawing elements.
/// </summary>
public class ColorChange: ModelElement
{
  /// <summary>
  /// Consider alpha values.
  /// </summary>
  public bool? UseAlpha { get; set; }

  /// <summary>
  /// Change color from.
  /// </summary>
  public ColorType? ColorFrom { get; set; }

  /// <summary>
  /// Change color to.
  /// </summary>
  public ColorType? ColorTo { get; set; }
}