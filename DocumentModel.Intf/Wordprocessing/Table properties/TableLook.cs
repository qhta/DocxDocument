namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableLook Class.
/// </summary>
public class TableLook: ModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public HexChar? Val { get; set; }

  /// <summary>
  ///   firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstRow { get; set; }

  /// <summary>
  ///   lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastRow { get; set; }

  /// <summary>
  ///   firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstColumn { get; set; }

  /// <summary>
  ///   lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastColumn { get; set; }

  /// <summary>
  ///   noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NoHorizontalBand { get; set; }

  /// <summary>
  ///   noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NoVerticalBand { get; set; }
}