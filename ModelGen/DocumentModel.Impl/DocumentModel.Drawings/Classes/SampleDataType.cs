namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public class SampleDataTypeImpl: ModelElementImpl, SampleDataType
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public virtual DataModel? DataModel
  {
    get;
    set;
  }
  
}
