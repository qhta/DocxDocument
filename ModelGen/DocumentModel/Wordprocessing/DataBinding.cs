namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the information that shall be used to establish a mapping between the nearest ancestor structured document tag and an XML element stored within a Custom XML Data part in the current WordprocessingML document.
/// </summary>
public partial class DataBinding: ModelElement<DXW.DataBinding>
{
  public DataBinding(): base(){ }
  
  public DataBinding(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataBinding(DXW.DataBinding openXmlElement): base(openXmlElement) { }
  
  
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
