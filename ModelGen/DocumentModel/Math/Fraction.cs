namespace DocumentModel.Math;


/// <summary>
///   Fraction Function.
/// </summary>
public partial class Fraction: ModelElement<DXM.Fraction>
{
  public Fraction(): base(){ }
  
  public Fraction(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Fraction(DXM.Fraction openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fraction Properties.
  /// </summary>
  [DataMember]
  public DMM.FractionProperties? FractionProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Numerator.
  /// </summary>
  [DataMember]
  public DMM.Numerator? Numerator
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
  
  /// <summary>
  ///   Denominator.
  /// </summary>
  [DataMember]
  public DMM.Denominator? Denominator
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
