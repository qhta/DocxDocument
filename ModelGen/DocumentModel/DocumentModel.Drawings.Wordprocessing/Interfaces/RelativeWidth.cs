namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public interface RelativeWidth
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.SizeRelativeHorizontallyKind? ObjectId { get ; set; }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  public String? PercentageWidth { get ; set; }
  
}
