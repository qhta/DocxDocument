namespace DocumentModel.Wordprocessing;

/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public class DivBorder: ModelElement
{
  /// <summary>
  ///   Top Border for HTML div.
  /// </summary>
  public BorderType? TopBorder { get; set; }

  /// <summary>
  ///   Left Border for HTML div.
  /// </summary>
  public BorderType? LeftBorder { get; set; }

  /// <summary>
  ///   Bottom Border for HTML div.
  /// </summary>
  public BorderType? BottomBorder { get; set; }

  /// <summary>
  ///   Right Border for HTML div.
  /// </summary>
  public BorderType? RightBorder { get; set; }
}