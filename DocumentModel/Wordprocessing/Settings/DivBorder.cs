namespace DocumentModel.Wordprocessing;

/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public class DivBorder: ModelElement
{
  /// <summary>
  ///   Top Border for HTML div.
  /// </summary>
  public Border? TopBorder { get; set; }

  /// <summary>
  ///   Left Border for HTML div.
  /// </summary>
  public Border? LeftBorder { get; set; }

  /// <summary>
  ///   Bottom Border for HTML div.
  /// </summary>
  public Border? BottomBorder { get; set; }

  /// <summary>
  ///   Right Border for HTML div.
  /// </summary>
  public Border? RightBorder { get; set; }
}