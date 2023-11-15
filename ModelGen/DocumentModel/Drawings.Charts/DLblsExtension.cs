namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DLblsExtension Class.
/// </summary>
public partial class DLblsExtension: ModelElement<DXDC.DLblsExtension>
{
  public DLblsExtension(): base(){ }
  
  public DLblsExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DLblsExtension(DXDC.DLblsExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDC13.ChartText? ChartText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC13.DataLabelFieldTable? DataLabelFieldTable
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC13.ShowDataLabelsRange? ShowDataLabelsRange
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
  }
  
  [DataMember]
  public DMDC13.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC13.Layout? Layout
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC13.ShowLeaderLines? ShowLeaderLines
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
  }
  
  [DataMember]
  public DMDC13.LeaderLines? LeaderLines
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
