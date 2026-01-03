namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundRemoval interface.
/// </summary>
public interface BackgroundRemoval: IModelElement
{
  /// <summary>
  ///   t
  /// </summary>
  public Int32? MarqueeTop { get; set; }
  /// <summary>
  ///   b
  /// </summary>
  public Int32? MarqueeBottom { get; set; }
  /// <summary>
  ///   l
  /// </summary>
  public Int32? MarqueeLeft { get; set; }
  /// <summary>
  ///   r
  /// </summary>
  public Int32? MarqueeRight { get; set; }
  public Collection<ForegroundMark>? ForegroundMarks { get; set; }
  public Collection<BackgroundMark>? BackgroundMarks { get; set; }
}