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
  public DocumentModel.HexInt? StoreItemId
  {
    get => HexIntConverter.GetValue(_Element?.StoreItemId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
