namespace DocumentModel.Interop;

/// <summary>
/// Represents a custom mailing label.
/// </summary>
public partial interface CustomLabel : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The top margin.
  /// </summary>
  public float TopMargin { get; set; }

  /// <summary>
  /// The side margin.
  /// </summary>
  public float SideMargin { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The vertical pitch.
  /// </summary>
  public float VerticalPitch { get; set; }

  /// <summary>
  /// The horizontal pitch.
  /// </summary>
  public float HorizontalPitch { get; set; }

  /// <summary>
  /// The number across.
  /// </summary>
  public int NumberAcross { get; set; }

  /// <summary>
  /// The number down.
  /// </summary>
  public int NumberDown { get; set; }

  /// <summary>
  /// The dot matrix.
  /// </summary>
  public bool DotMatrix { get; }

  /// <summary>
  /// The page size.
  /// </summary>
  public WdCustomLabelPageSize PageSize { get; set; }

  /// <summary>
  /// The valid.
  /// </summary>
  public bool Valid { get; }
}
