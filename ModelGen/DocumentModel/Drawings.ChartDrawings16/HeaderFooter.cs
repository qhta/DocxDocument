namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the HeaderFooter Class.
/// </summary>
public partial class HeaderFooter: ModelElement<DXO16DCD.HeaderFooter>
{
  public HeaderFooter(): base(){ }
  
  public HeaderFooter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderFooter(DXO16DCD.HeaderFooter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? AlignWithMargins
  {
    get => _Element?.AlignWithMargins?.Value;
    set => _ExistingElement.AlignWithMargins = value;
  }
  
  
  /// <summary>
  ///   differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? DifferentOddEven
  {
    get => _Element?.DifferentOddEven?.Value;
    set => _ExistingElement.DifferentOddEven = value;
  }
  
  
  /// <summary>
  ///   differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? DifferentFirst
  {
    get => _Element?.DifferentFirst?.Value;
    set => _ExistingElement.DifferentFirst = value;
  }
  
  
  /// <summary>
  ///   OddHeaderXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.OddHeaderXsdstring? OddHeaderXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   OddFooterXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.OddFooterXsdstring? OddFooterXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   EvenHeaderXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.EvenHeaderXsdstring? EvenHeaderXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   EvenFooterXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.EvenFooterXsdstring? EvenFooterXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   FirstHeaderXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.FirstHeaderXsdstring? FirstHeaderXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   FirstFooterXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.FirstFooterXsdstring? FirstFooterXsdstring
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
