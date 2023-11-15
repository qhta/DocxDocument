namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TickLabels Class.
/// </summary>
public partial class TickLabels: ModelElement<DXO16DCD.TickLabels>
{
  public TickLabels(): base(){ }
  
  public TickLabels(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TickLabels(DXO16DCD.TickLabels openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
