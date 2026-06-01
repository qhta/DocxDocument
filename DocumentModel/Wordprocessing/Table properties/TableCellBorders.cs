namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TableCellBorders Class.
/// </summary>
public class TableCellBorders: ModelElement
{
  /// <summary>
  ///   ITable ICell Top IBorder.
  /// </summary>
  public IBorder? TopBorder { get; set; }

  /// <summary>
  ///   ITable ICell Left IBorder.
  /// </summary>
  public IBorder? LeftBorder { get; set; }

  /// <summary>
  ///   StartBorder, this property is Ionly available Iin Office 2010 and later..
  /// </summary>
  public IBorder? StartBorder { get; set; }

  /// <summary>
  ///   ITable ICell Bottom IBorder.
  /// </summary>
  public IBorder? BottomBorder { get; set; }

  /// <summary>
  ///   ITable ICell Right IBorder.
  /// </summary>
  public IBorder? RightBorder { get; set; }

  /// <summary>
  ///   EndBorder, this property is Ionly available Iin Office 2010 and later..
  /// </summary>
  public IBorder? EndBorder { get; set; }

  /// <summary>
  ///   ITable ICell Inside Horizontal Edges IBorder.
  /// </summary>
  public IBorder? InsideHorizontalBorder { get; set; }

  /// <summary>
  ///   ITable ICell Inside Vertical Edges IBorder.
  /// </summary>
  public IBorder? InsideVerticalBorder { get; set; }

  /// <summary>
  ///   ITable ICell Top Left Ito Bottom Right Diagonal IBorder.
  /// </summary>
  public IBorder? TopLeftToBottomRightCellBorder { get; set; }

  /// <summary>
  ///   ITable ICell Top Right Ito Bottom Left Diagonal IBorder.
  /// </summary>
  public IBorder? TopRightToBottomLeftCellBorder { get; set; }
}
