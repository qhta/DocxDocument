namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Data Model.
/// </summary>
public class DataModel: ModelElement
{
  /// <summary>
  ///   IPoint IList.
  /// </summary>
  public PointList? PointList { get; set; }

  /// <summary>
  ///   Connection IList.
  /// </summary>
  public ConnectionList? ConnectionList { get; set; }

  /// <summary>
  ///   Background Formatting.
  /// </summary>
  public Background? Background { get; set; }

  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  public Whole? Whole { get; set; }

  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  public DataModelExtensionList? DataModelExtensionList { get; set; }
}
