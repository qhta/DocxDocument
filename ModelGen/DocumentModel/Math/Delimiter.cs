namespace DocumentModel.Math;


/// <summary>
///   Delimiter Function.
/// </summary>
public partial class Delimiter: ModelElement<DXM.Delimiter>
{
  public Delimiter(): base(){ }
  
  public Delimiter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Delimiter(DXM.Delimiter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  [DataMember]
  public DMM.DelimiterProperties? DelimiterProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
