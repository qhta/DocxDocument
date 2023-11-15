namespace DocumentModel.Word13;


/// <summary>
///   This element specifies the information used to establish a mapping between the parent structured document tag and an XML element stored within a Custom XML Data part in the current WordprocessingML document.
/// </summary>
public partial class DataBinding: ModelElement<DXO13W.DataBinding>
{
  public DataBinding(): base(){ }
  
  public DataBinding(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataBinding(DXO13W.DataBinding openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   XML Namespace Prefix Mappings
  /// </summary>
  [DataMember]
  public String? PrefixMappings
  {
    get => _Element?.PrefixMappings;
    set => _ExistingElement.PrefixMappings = value;
  }
  
  
  /// <summary>
  ///   XPath
  /// </summary>
  [DataMember]
  public String? XPath
  {
    get => _Element?.XPath;
    set => _ExistingElement.XPath = value;
  }
  
  
  /// <summary>
  ///   Custom XML Data Storage ID
  /// </summary>
  [DataMember]
  public String? StoreItemId
  {
    get => _Element?.StoreItemId;
    set => _ExistingElement.StoreItemId = value;
  }
  
}
