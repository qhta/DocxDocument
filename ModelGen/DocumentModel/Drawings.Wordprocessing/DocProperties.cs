namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Drawing Object Non-Visual Properties.
/// </summary>
public partial class DocProperties: ModelElement<DXDW.DocProperties>
{
  public DocProperties(): base(){ }
  
  public DocProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocProperties(DXDW.DocProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Name compatible with Object Model (non-unique).
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  [DataMember]
  public String? Description
  {
    get => _Element?.Description;
    set => _ExistingElement.Description = value;
  }
  
  
  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get => _Element?.Hidden?.Value;
    set => _ExistingElement.Hidden = value;
  }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   Hyperlink associated with clicking or selecting the element..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkOnClick? HyperlinkOnClick
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
  }
  
  
  /// <summary>
  ///   Hyperlink associated with hovering over the element..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkOnHover? HyperlinkOnHover
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.HyperlinkType");
  }
  
  
  /// <summary>
  ///   Future extension.
  /// </summary>
  [DataMember]
  public DMD.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
