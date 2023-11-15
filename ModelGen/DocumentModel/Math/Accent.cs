namespace DocumentModel.Math;


/// <summary>
///   Accent.
/// </summary>
public partial class Accent: ModelElement<DXM.Accent>
{
  public Accent(): base(){ }
  
  public Accent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent(DXM.Accent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Accent Properties.
  /// </summary>
  [DataMember]
  public DMM.AccentProperties? AccentProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
