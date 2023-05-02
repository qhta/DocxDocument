namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Data Model.
/// </summary>
public class DataModelRoot: ModelElement
{
  /// <summary>
  ///   Point List.
  /// </summary>
  public PointList? PointList { get; set; }

  /// <summary>
  ///   Connection List.
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