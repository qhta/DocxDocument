namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a gradient stop. A gradient stop consists of a position where the stop appears in the color band.
/// </summary>
public partial class GradientStop: ModelElement<DXO10W.GradientStop>
{
  public GradientStop(): base(){ }
  
  public GradientStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientStop(DXO10W.GradientStop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   pos, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StopPosition
  {
    get => _Element?.StopPosition?.Value;
    set => _ExistingElement.StopPosition = value;
  }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  [DataMember]
  public DM.HexBinary? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  [DataMember]
  public DMW10.SchemeColorKind? SchemeColor
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
