namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentExtensible Class.
/// </summary>
public partial class CommentExtensible: ModelElement<DXO21WCE.CommentExtensible>
{
  public CommentExtensible(): base(){ }
  
  public CommentExtensible(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentExtensible(DXO21WCE.CommentExtensible openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   durableId, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? DurableId
  {
    get => HexIntConverter.GetValue(_Element?.DurableId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DateTime? DateUtc
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public Boolean? IntelligentPlaceholder
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMW.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
