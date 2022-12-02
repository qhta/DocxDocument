namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public interface IDivBorder // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public IBorderType? RightBorder { get ; set; }
  
}
