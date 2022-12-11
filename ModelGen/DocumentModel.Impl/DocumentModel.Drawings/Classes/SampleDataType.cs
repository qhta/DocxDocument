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
  
  public SampleDataTypeImpl(): base() {}
  
  public SampleDataTypeImpl(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault
  {
    get => (Boolean?)OpenXmlElement?.UseDefault?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseDefault = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public virtual DataModel? DataModel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
