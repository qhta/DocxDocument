namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public interface IDivBorder // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public IRightBorder? RightBorder { get ; set; }
  
}
