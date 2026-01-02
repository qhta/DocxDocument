namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
public class SampleDataType: ModelElement
{
  /// <summary>
  ///   Use Default
  /// </summary>
  public bool? UseDefault { get; set; }
  /// <summary>
  ///   Data Model.
  /// </summary>
  public DataModel? DataModel { get; set; }
}