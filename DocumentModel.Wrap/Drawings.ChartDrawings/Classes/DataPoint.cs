namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public class DataPoint: ModelElement
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}