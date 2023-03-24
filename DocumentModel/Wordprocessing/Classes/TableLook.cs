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
  public Boolean? FirstRow { get; set; }

  /// <summary>
  ///   lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRow { get; set; }

  /// <summary>
  ///   firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstColumn { get; set; }

  /// <summary>
  ///   lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastColumn { get; set; }

  /// <summary>
  ///   noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoHorizontalBand { get; set; }

  /// <summary>
  ///   noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoVerticalBand { get; set; }
}