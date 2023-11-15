namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Frame Properties.
/// </summary>
public partial class Frame: ModelElement<DXW.Frame>
{
  public Frame(): base(){ }
  
  public Frame(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Frame(DXW.Frame openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Frame Size.
  /// </summary>
  [DataMember]
  public DMW.FrameSize? FrameSize
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Frame Name.
  /// </summary>
  [DataMember]
  public DMW.FrameName? FrameName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String255Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String255Type");
  }
  
  
  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  [DataMember]
  public DMW.SourceFileReference? SourceFileReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.RelationshipType");
  }
  
  
  /// <summary>
  ///   Left and Right Margin for Frame.
  /// </summary>
  [DataMember]
  public DMW.MarginWidth? MarginWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.PixelsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.PixelsMeasureType");
  }
  
  
  /// <summary>
  ///   Top and Bottom Margin for Frame.
  /// </summary>
  [DataMember]
  public DMW.MarginHeight? MarginHeight
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.PixelsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.PixelsMeasureType");
  }
  
  
  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  [DataMember]
  public DMW.FrameScrollbarVisibilityKind? ScrollbarVisibility
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Frame Cannot Be Resized.
  /// </summary>
  [DataMember]
  public DMW.NoResizeAllowed? NoResizeAllowed
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  [DataMember]
  public DMW.LinkedToFile? LinkedToFile
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
}
