namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundRemoval Class.
/// </summary>
public record BackgroundRemoval
{
  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeTop { get; set; }

  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeBottom { get; set; }

  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeLeft { get; set; }

  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeRight { get; set; }

  public Collection<ForegroundMark>? ForegroundMarks { get; set; }

  public Collection<BackgroundMark>? BackgroundMarks { get; set; }
}