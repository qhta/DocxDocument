namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public partial class RelativeHeight: ModelElement<DXO10WD.RelativeHeight>
{
  public RelativeHeight(): base(){ }
  
  public RelativeHeight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeHeight(DXO10WD.RelativeHeight openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  [DataMember]
  public DMWD.PercentageHeight? PercentageHeight
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
