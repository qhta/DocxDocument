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
    get
    {
      return StringValueConverter.GetValue(_Element?.PrefixMappings);
    }
    set
    {
      _ExistingElement.PrefixMappings = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   XPath
  /// </summary>
  [DataMember]
  public String? XPath
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.XPath);
    }
    set
    {
      _ExistingElement.XPath = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Custom XML Data Storage ID
  /// </summary>
  [DataMember]
  public String? StoreItemId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StoreItemId);
    }
    set
    {
      _ExistingElement.StoreItemId = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
