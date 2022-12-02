namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public interface ISampleDataType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Use Default
  /// </summary>
  public System.Boolean? UseDefault { get ; set; }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public DocumentModel.Drawing.IDataModel? DataModel { get ; set; }
  
}
