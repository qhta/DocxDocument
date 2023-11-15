namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public partial class CommentsExtensible: ModelElement<DXO21WCE.CommentsExtensible>
{
  public CommentsExtensible(): base(){ }
  
  public CommentsExtensible(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentsExtensible(DXO21WCE.CommentsExtensible openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
