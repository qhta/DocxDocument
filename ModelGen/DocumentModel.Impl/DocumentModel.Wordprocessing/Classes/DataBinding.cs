namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public class DataBindingImpl: ModelElementImpl, DataBinding
{
  public DocumentFormat.OpenXml.Wordprocessing.DataBinding? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DataBinding?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataBindingImpl(): base() {}
  
  public DataBindingImpl(DocumentFormat.OpenXml.Wordprocessing.DataBinding openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public String? PrefixMappings
  {
    get => (System.String?)OpenXmlElement?.PrefixMappings?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PrefixMappings = (System.String?)value;
    }
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  public String? XPath
  {
    get => (System.String?)OpenXmlElement?.XPath?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.XPath = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  public String? StoreItemId
  {
    get => (System.String?)OpenXmlElement?.StoreItemId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StoreItemId = (System.String?)value;
    }
  }
  
}
