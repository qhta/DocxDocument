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
  
  /// <summary>
  /// XML Namespace Prefix Mappings
  /// </summary>
  public String? PrefixMappings
  {
    get;
    set;
  }
  
  /// <summary>
  /// XPath
  /// </summary>
  public String? XPath
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom XML Data Storage ID
  /// </summary>
  public String? StoreItemId
  {
    get;
    set;
  }
  
}
