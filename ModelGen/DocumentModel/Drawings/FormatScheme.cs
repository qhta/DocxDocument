namespace DocumentModel.Drawings;


/// <summary>
///   This element contains the background fill styles, effect styles, fill styles, and line styles which define the style matrix for a theme.  The style matrix consists of subtle, moderate, and intense fills, lines, and effects.  The background fills are not generally thought of to directly be associated with the matrix, but do play a role in the style of the overall document.  Usually, a given object chooses a single line style, a single fill style, and a single effect style in order to define the overall final look of the object.
/// </summary>
public partial class FormatScheme: ModelElement<DXD.FormatScheme>
{
  public FormatScheme(): base(){ }
  
  public FormatScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormatScheme(DXD.FormatScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Defines the name for the format scheme.  The name is simply a human readable string which identifies the format scheme in the user interface.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Fill Style List.
  /// </summary>
  [DataMember]
  public DMD.FillStyleList? FillStyleList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Line Style List.
  /// </summary>
  [DataMember]
  public DMD.LineStyleList? LineStyleList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Effect Style List.
  /// </summary>
  [DataMember]
  public DMD.EffectStyleList? EffectStyleList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Background Fill Style List.
  /// </summary>
  [DataMember]
  public DMD.BackgroundFillStyleList? BackgroundFillStyleList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
