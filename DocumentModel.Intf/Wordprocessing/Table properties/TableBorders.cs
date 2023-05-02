namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableBorders Class.
/// </summary>
public class TableBorders: ModelElement
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
  ///   StartBorder, this property is only available in Office 2010 and later..
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
  ///   EndBorder, this property is only available in Office 2010 and later..
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