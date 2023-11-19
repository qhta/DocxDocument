namespace DocumentModel.Wordprocessing;


/// <summary>
///   Abstract Numbering Definition.
/// </summary>
public partial class AbstractNum: ModelElement<DXW.AbstractNum>
{
  public AbstractNum(): base(){ }
  
  public AbstractNum(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AbstractNum(DXW.AbstractNum openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Abstract Numbering Definition ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? AbstractNumberId
  {
    get => HexIntConverter.GetValue(_Element?.AbstractNumberId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Identifier.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Nsid
  {
    get => _Element?.GetHexIntVal<DXW.Nsid>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  [DataMember]
  public DMW.MultiLevelKind? MultiLevelType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  [DataMember]
  public DMW.TemplateCode? TemplateCode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType");
  }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Name.
  /// </summary>
  [DataMember]
  public DMW.AbstractNumDefinitionName? AbstractNumDefinitionName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Numbering Style Definition.
  /// </summary>
  [DataMember]
  public DMW.StyleLink? StyleLink
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Numbering Style Reference.
  /// </summary>
  [DataMember]
  public DMW.NumberingStyleLink? NumberingStyleLink
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
}
