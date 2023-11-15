namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBarType Class.
/// </summary>
public partial class UpDownBarType: ModelElement<DXDC.UpDownBarType>
{
  public UpDownBarType(): base(){ }
  
  public UpDownBarType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpDownBarType(DXDC.UpDownBarType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
