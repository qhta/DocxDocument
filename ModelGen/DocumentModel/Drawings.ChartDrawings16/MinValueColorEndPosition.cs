namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MinValueColorEndPosition Class.
/// </summary>
public partial class MinValueColorEndPosition: ModelElement<DXO16DCD.MinValueColorEndPosition>
{
  public MinValueColorEndPosition(): base(){ }
  
  public MinValueColorEndPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinValueColorEndPosition(DXO16DCD.MinValueColorEndPosition openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.ExtremeValueColorPosition? ExtremeValueColorPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public Double? NumberColorPosition
  {
    get => _Element?.GetIntVal<Double, DXO16DCD.NumberColorPosition>();
    set => _ExistingElement.SetIntVal<Double, DXO16DCD.NumberColorPosition>(value);
  }
  
  [DataMember]
  public Double? PercentageColorPosition
  {
    get => _Element?.GetIntVal<Double, DXO16DCD.PercentageColorPosition>();
    set => _ExistingElement.SetIntVal<Double, DXO16DCD.PercentageColorPosition>(value);
  }
  
}
