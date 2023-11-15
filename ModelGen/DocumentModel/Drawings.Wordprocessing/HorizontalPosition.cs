namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Horizontal Positioning.
/// </summary>
public partial class HorizontalPosition: ModelElement<DXDW.HorizontalPosition>
{
  public HorizontalPosition(): base(){ }
  
  public HorizontalPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HorizontalPosition(DXDW.HorizontalPosition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relative Horizontal Alignment.
  /// </summary>
  [DataMember]
  public DMDW.HorizontalAlignment? HorizontalAlignment
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Absolute Position Offset.
  /// </summary>
  [DataMember]
  public DMDW.PositionOffset? PositionOffset
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMWD.PercentagePositionHeightOffset? PercentagePositionHeightOffset
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
