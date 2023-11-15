namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class DataModelExtension: ModelElement<DXD.DataModelExtension>
{
  public DataModelExtension(): base(){ }
  
  public DataModelExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModelExtension(DXD.DataModelExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDO.DataModelExtensionBlock? DataModelExtensionBlock
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public Boolean? RecolorImages
  {
    get => _Element?.GetBoolVal<DXO10DD.RecolorImages>();
    set => _ExistingElement.SetBoolVal<DXO10DD.RecolorImages>(value);
  }
  
}
