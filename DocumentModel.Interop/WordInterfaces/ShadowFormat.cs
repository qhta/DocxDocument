namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
public partial interface ShadowFormat : InteropObject
{
  /// <summary>
  /// The fore color.
  /// </summary>
  public ColorFormat ForeColor { get; }

  /// <summary>
  /// The obscured.
  /// </summary>
  public Core.MsoTriState Obscured { get; set; }

  /// <summary>
  /// The offset x.
  /// </summary>
  public float OffsetX { get; set; }

  /// <summary>
  /// The offset y.
  /// </summary>
  public float OffsetY { get; set; }

  /// <summary>
  /// The transparency.
  /// </summary>
  public float Transparency { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public Core.MsoShadowType Type { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  public Core.MsoShadowStyle Style { get; set; }

  /// <summary>
  /// The blur.
  /// </summary>
  public float Blur { get; set; }

  /// <summary>
  /// The size.
  /// </summary>
  public float Size { get; set; }

  /// <summary>
  /// The rotate with shape.
  /// </summary>
  public Core.MsoTriState RotateWithShape { get; set; }
}
