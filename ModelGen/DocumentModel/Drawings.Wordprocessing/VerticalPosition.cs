namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Vertical Positioning.
/// </summary>
public partial class VerticalPosition: ModelElement<DXDW.VerticalPosition>
{
  public VerticalPosition(): base(){ }
  
  public VerticalPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public VerticalPosition(DXDW.VerticalPosition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  [DataMember]
  public DMDW.VerticalAlignment? VerticalAlignment
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   PositionOffset.
  /// </summary>
  [DataMember]
  public DMDW.PositionOffset? PositionOffset
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMWD.PercentagePositionVerticalOffset? PercentagePositionVerticalOffset
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
