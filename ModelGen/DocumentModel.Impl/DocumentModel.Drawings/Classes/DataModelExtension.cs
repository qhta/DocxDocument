namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public class DataModelExtensionImpl: ModelElementImpl, DataModelExtension
{
  public DocumentFormat.OpenXml.Drawing.DataModelExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.DataModelExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public DataModelExtensionBlock? DataModelExtensionBlock
  {
    get;
    set;
  }
  
  public Boolean? RecolorImages
  {
    get;
    set;
  }
  
}
