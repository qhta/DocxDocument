namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public interface RelativeHeight
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind? RelativeFrom { get ; set; }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public String? PercentageHeight { get ; set; }
  
}
