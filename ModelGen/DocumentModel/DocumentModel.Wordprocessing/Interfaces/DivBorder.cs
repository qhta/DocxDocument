namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public interface DivBorder
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder { get ; set; }
  
}
