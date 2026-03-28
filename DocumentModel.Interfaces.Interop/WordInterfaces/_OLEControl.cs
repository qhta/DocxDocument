namespace DocumentModel.Interop;

/// <summary>
/// Reserved for internal use.
/// </summary>
public partial interface _OLEControl
{
  /// <summary>
  /// The left.
  /// </summary>
  public float Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  public float Top { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The automation.
  /// </summary>
  public object Automation { get; }

  /// <summary>
  /// The alt html.
  /// </summary>
  public string AltHTML { get; set; }
}
