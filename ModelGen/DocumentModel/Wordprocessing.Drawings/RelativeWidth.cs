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
  ///   PercentageWidth.
  /// </summary>
  [DataMember]
  public DMWD.PercentageWidth? PercentageWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
