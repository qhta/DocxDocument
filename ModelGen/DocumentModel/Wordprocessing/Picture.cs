namespace DocumentModel.Wordprocessing;


/// <summary>
///   VML Object.
/// </summary>
public partial class Picture: ModelElement<DXW.Picture>
{
  public Picture(): base(){ }
  
  public Picture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Picture(DXW.Picture openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? AnchorId
  {
    get => HexIntConverter.GetValue(_Element?.AnchorId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  [DataMember]
  public DMW.MovieReference? MovieReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
  }
  
  [DataMember]
  public DMW.Control? Control
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
