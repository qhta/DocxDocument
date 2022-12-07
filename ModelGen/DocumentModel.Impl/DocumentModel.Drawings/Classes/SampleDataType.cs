namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public class SampleDataTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType>, SampleDataType
{
  /// <summary>
  /// Data Model.
  /// </summary>
  public virtual DataModel? DataModel
  {
    get;
    set;
  }
  
}
