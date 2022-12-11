namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DataBinding Class.
/// </summary>
public class DataBindingImpl: ModelElementImpl, DataBinding
{
  public DocumentFormat.OpenXml.Office2013.Word.DataBinding? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.DataBinding?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataBindingImpl(): base() {}
  
  public DataBindingImpl(DocumentFormat.OpenXml.Office2013.Word.DataBinding openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public String? PrefixMappings
  {
    get => (String?)OpenXmlElement?.PrefixMappings?.Value;
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
    get => (String?)OpenXmlElement?.XPath?.Value;
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
    get => (String?)OpenXmlElement?.StoreItemId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StoreItemId = (System.String?)value;
    }
  }
  
}
