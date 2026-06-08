namespace DocumentModel.Wordprocessing;

/// <summary>
///   Set of IBorders for HTML div.
/// </summary>
public class DivBorder: ModelElement
{
  /// <summary>
  ///   Top IBorder for HTML div.
  /// </summary>
  public IBorder? TopBorder { get; set; }

  /// <summary>
  ///   Left IBorder for HTML div.
  /// </summary>
  public IBorder? LeftBorder { get; set; }

  /// <summary>
  ///   Bottom IBorder for HTML div.
  /// </summary>
  public IBorder? BottomBorder { get; set; }

  /// <summary>
  ///   Right IBorder for HTML div.
  /// </summary>
  public IBorder? RightBorder { get; set; }
}
