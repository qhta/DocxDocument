namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public partial class RelativeWidth: ModelElement<DXO10WD.RelativeWidth>
{
  public RelativeWidth(): base(){ }
  
  public RelativeWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeWidth(DXO10WD.RelativeWidth openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ObjectId
  {
    get => HexIntConverter.GetValue(_Element?.ObjectId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  [DataMember]
  public DMWD.PercentageWidth? PercentageWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
