namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public interface SampleDataType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault { get ; set; }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public DataModel? DataModel { get ; set; }
  
}
