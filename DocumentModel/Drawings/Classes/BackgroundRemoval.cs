namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackgroundRemoval Class.
/// </summary>
public class BackgroundRemoval: ModelElement
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