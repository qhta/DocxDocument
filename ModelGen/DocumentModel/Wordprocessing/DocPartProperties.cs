namespace DocumentModel.Wordprocessing;


/// <summary>
///   Glossary Document Entry Properties.
/// </summary>
public partial class DocPartProperties: ModelElement<DXW.DocPartProperties>
{
  public DocPartProperties(): base(){ }
  
  public DocPartProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartProperties(DXW.DocPartProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Entry Name.
  /// </summary>
  [DataMember]
  public DMW.DocPartName? DocPartName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Associated Paragraph Style Name.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? StyleId
  {
    get => _Element?.GetHexIntVal<DXW.StyleId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Entry Categorization.
  /// </summary>
  [DataMember]
  public DMW.Category? Category
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Entry Types.
  /// </summary>
  [DataMember]
  public DMW.DocPartTypes? DocPartTypes
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Entry Insertion Behaviors.
  /// </summary>
  [DataMember]
  public DMW.Behaviors? Behaviors
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Description for Entry.
  /// </summary>
  [DataMember]
  public DMW.Description? Description
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Entry ID.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? DocPartId
  {
    get => _Element?.GetHexIntVal<DXW.DocPartId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
