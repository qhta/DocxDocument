namespace DocumentModel.Math;


/// <summary>
///   Superscript Function.
/// </summary>
public partial class Superscript: ModelElement<DXM.Superscript>
{
  public Superscript(): base(){ }
  
  public Superscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Superscript(DXM.Superscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SuperscriptProperties? SuperscriptProperties
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
  
  
  /// <summary>
  ///   Superscript (Superscript function).
  /// </summary>
  [DataMember]
  public DMM.SuperArgument? SuperArgument
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
