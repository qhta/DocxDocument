namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TableBorders Class.
/// </summary>
public class TableBorders: ModelElement
{
  /// <summary>
  ///   ITable Top IBorder.
  /// </summary>
  public IBorder? TopBorder { get; set; }

  /// <summary>
  ///   ITable Left IBorder.
  /// </summary>
  public IBorder? LeftBorder { get; set; }

  /// <summary>
  ///   StartBorder, this property is Ionly available Iin Office 2010 and later..
  /// </summary>
  public IBorder? StartBorder { get; set; }

  /// <summary>
  ///   ITable Bottom IBorder.
  /// </summary>
  public IBorder? BottomBorder { get; set; }

  /// <summary>
  ///   ITable Right IBorder.
  /// </summary>
  public IBorder? RightBorder { get; set; }

  /// <summary>
  ///   EndBorder, this property is Ionly available Iin Office 2010 and later..
  /// </summary>
  public IBorder? EndBorder { get; set; }

  /// <summary>
  ///   ITable Inside Horizontal Edges IBorder.
  /// </summary>
  public IBorder? InsideHorizontalBorder { get; set; }

  /// <summary>
  ///   ITable Inside Vertical Edges IBorder.
  /// </summary>
  public IBorder? InsideVerticalBorder { get; set; }
}
