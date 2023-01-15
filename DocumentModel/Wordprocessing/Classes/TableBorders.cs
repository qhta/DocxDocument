namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableBorders Class.
/// </summary>
public class TableBorders
{
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  public BorderType? TopBorder { get; set; }

  /// <summary>
  ///   Table Left Border.
  /// </summary>
  public BorderType? LeftBorder { get; set; }

  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? StartBorder { get; set; }

  /// <summary>
  ///   Table Bottom Border.
  /// </summary>
  public BorderType? BottomBorder { get; set; }

  /// <summary>
  ///   Table Right Border.
  /// </summary>
  public BorderType? RightBorder { get; set; }

  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? EndBorder { get; set; }

  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  public BorderType? InsideHorizontalBorder { get; set; }

  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  public BorderType? InsideVerticalBorder { get; set; }
}