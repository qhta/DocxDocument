namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Legend Class.
/// </summary>
public partial class Legend: ModelElement<DXO16DCD.Legend>
{
  public Legend(): base(){ }
  
  public Legend(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Legend(DXO16DCD.Legend openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Overlay
  {
    get => _Element?.Overlay?.Value;
    set => _ExistingElement.Overlay = value;
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
