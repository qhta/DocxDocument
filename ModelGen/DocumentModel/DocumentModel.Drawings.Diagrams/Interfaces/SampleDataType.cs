namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public partial interface SampleDataType
{
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault { get; set; }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModel? DataModel { get; set; }
  
}
