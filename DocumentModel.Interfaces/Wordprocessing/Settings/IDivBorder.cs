namespace DocumentModel.Wordprocessing;
/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public interface IDivBorder: IModelElement
{
  /// <summary>
  ///   Top Border for HTML div.
  /// </summary>
  public IBorder? TopBorder { get; set; }
  /// <summary>
  ///   Left Border for HTML div.
  /// </summary>
  public IBorder? LeftBorder { get; set; }
  /// <summary>
  ///   Bottom Border for HTML div.
  /// </summary>
  public IBorder? BottomBorder { get; set; }
  /// <summary>
  ///   Right Border for HTML div.
  /// </summary>
  public IBorder? RightBorder { get; set; }
}