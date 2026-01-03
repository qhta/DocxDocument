namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableLook Class.
/// </summary>
public interface TableLook: IModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public IHexChar? Val { get; set; }
  /// <summary>
  ///   firstRow
  /// </summary>
  public bool? FirstRow { get; set; }
  /// <summary>
  ///   lastRow
  /// </summary>
  public bool? LastRow { get; set; }
  /// <summary>
  ///   firstColumn
  /// </summary>
  public bool? FirstColumn { get; set; }
  /// <summary>
  ///   lastColumn
  /// </summary>
  public bool? LastColumn { get; set; }
  /// <summary>
  ///   noHBand
  /// </summary>
  public bool? NoHorizontalBand { get; set; }
  /// <summary>
  ///   noVBand
  /// </summary>
  public bool? NoVerticalBand { get; set; }
}