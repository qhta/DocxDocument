namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Text Class.
/// </summary>
public partial class Text: ModelElement<DXO16DCD.Text>
{
  public Text(): base(){ }
  
  public Text(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Text(DXO16DCD.Text openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TextData.
  /// </summary>
  [DataMember]
  public DMDCD16.TextData? TextData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   RichTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.RichTextBody? RichTextBody
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType");
  }
  
}
