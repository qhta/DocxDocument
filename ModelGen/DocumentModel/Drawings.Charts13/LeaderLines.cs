namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the LeaderLines Class.
/// </summary>
public partial class LeaderLines: ModelElement<DXO13DC.LeaderLines>
{
  public LeaderLines(): base(){ }
  
  public LeaderLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeaderLines(DXO13DC.LeaderLines openXmlElement): base(openXmlElement) { }
  
  
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
