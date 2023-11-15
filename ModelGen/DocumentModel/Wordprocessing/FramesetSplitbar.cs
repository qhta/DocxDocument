namespace DocumentModel.Wordprocessing;


/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public partial class FramesetSplitbar: ModelElement<DXW.FramesetSplitbar>
{
  public FramesetSplitbar(): base(){ }
  
  public FramesetSplitbar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FramesetSplitbar(DXW.FramesetSplitbar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  [DataMember]
  public DMW.Width? Width
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  [DataMember]
  public DMW.Color? Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  [DataMember]
  public DMW.NoBorder? NoBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  [DataMember]
  public DMW.FlatBorders? FlatBorders
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
}
