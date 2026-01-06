namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableBorders Class.
/// </summary>
public interface TableBorders
{
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  public Border? TopBorder { get; set; }
  /// <summary>
  ///   Table Left Border.
  /// </summary>
  public Border? LeftBorder { get; set; }
  /// <summary>
  ///   StartBorder.
  /// </summary>
  public Border? StartBorder { get; set; }
  /// <summary>
  ///   Table Bottom Border.
  /// </summary>
  public Border? BottomBorder { get; set; }
  /// <summary>
  ///   Table Right Border.
  /// </summary>
  public Border? RightBorder { get; set; }
  /// <summary>
  ///   EndBorder.
  /// </summary>
  public Border? EndBorder { get; set; }
  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  public Border? InsideHorizontalBorder { get; set; }
  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  public Border? InsideVerticalBorder { get; set; }
}