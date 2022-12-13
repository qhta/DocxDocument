namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public interface SampleDataType
{
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault { get ; set; }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public DocumentModel.Drawings.DataModel? DataModel { get ; set; }
  
}
