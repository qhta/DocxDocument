namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public class DataModelExtensionListImpl: ModelElementImpl, DataModelExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataModelExtensionListImpl(): base() {}
  
  public DataModelExtensionListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DataModelExtension>? DataModelExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
