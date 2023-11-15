namespace DocumentModel.Math;


/// <summary>
///   Phantom Function.
/// </summary>
public partial class Phantom: ModelElement<DXM.Phantom>
{
  public Phantom(): base(){ }
  
  public Phantom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Phantom(DXM.Phantom openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  [DataMember]
  public DMM.PhantomProperties? PhantomProperties
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
