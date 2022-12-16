namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public interface RelativeHeight
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.SizeRelativeVerticallyKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public String? PercentageHeight { get ; set; }
  
}
