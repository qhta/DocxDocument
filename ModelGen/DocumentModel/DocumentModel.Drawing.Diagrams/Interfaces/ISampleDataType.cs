namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public interface ISampleDataType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault { get ; set; }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public IDataModel? DataModel { get ; set; }
  
}
