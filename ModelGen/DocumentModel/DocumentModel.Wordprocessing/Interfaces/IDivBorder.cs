namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public interface IDivBorder // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? RightBorder { get ; set; }
  
}
