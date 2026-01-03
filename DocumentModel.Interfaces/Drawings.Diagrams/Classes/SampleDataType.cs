namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
public interface SampleDataType: IModelElement
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