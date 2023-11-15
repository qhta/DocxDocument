namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColors Class.
/// </summary>
public partial class ValueColors: ModelElement<DXO16DCD.ValueColors>
{
  public ValueColors(): base(){ }
  
  public ValueColors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueColors(DXO16DCD.ValueColors openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   MinColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement");
  }
  
  
  /// <summary>
  ///   MidColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement");
  }
  
  
  /// <summary>
  ///   MaxColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement");
  }
  
}
