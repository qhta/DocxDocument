namespace DocumentModel.Wordprocessing;

/// <summary>
///   Set of IBorders Ifor HTML div.
/// </summary>
public class DivBorder: ModelElement
{
  /// <summary>
  ///   Top IBorder Ifor HTML div.
  /// </summary>
  public IBorder? TopBorder { get; set; }

  /// <summary>
  ///   Left IBorder Ifor HTML div.
  /// </summary>
  public IBorder? LeftBorder { get; set; }

  /// <summary>
  ///   Bottom IBorder Ifor HTML div.
  /// </summary>
  public IBorder? BottomBorder { get; set; }

  /// <summary>
  ///   Right IBorder Ifor HTML div.
  /// </summary>
  public IBorder? RightBorder { get; set; }
}
