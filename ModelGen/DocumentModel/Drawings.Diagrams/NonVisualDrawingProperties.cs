namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
public partial class NonVisualDrawingProperties: ModelElement<DXO10DD.NonVisualDrawingProperties>
{
  public NonVisualDrawingProperties(): base(){ }
  
  public NonVisualDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualDrawingProperties(DXO10DD.NonVisualDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
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
