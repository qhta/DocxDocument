namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of colors which are referred to as a color scheme.  The color scheme is responsible for defining a list of twelve colors.  The twelve colors consist of six accent colors, two dark colors, two light colors and a color for each of a hyperlink and followed hyperlink.
/// </summary>
public partial class ColorScheme: ModelElement<DXD.ColorScheme>
{
  public ColorScheme(): base(){ }
  
  public ColorScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorScheme(DXD.ColorScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   The common name for this color scheme.  This name can show up in the user interface in a list of color schemes.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Dark 1.
  /// </summary>
  [DataMember]
  public DMD.Dark1Color? Dark1Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Light 1.
  /// </summary>
  [DataMember]
  public DMD.Light1Color? Light1Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Dark 2.
  /// </summary>
  [DataMember]
  public DMD.Dark2Color? Dark2Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Light 2.
  /// </summary>
  [DataMember]
  public DMD.Light2Color? Light2Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Accent 1.
  /// </summary>
  [DataMember]
  public DMD.Accent1Color? Accent1Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Accent 2.
  /// </summary>
  [DataMember]
  public DMD.Accent2Color? Accent2Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Accent 3.
  /// </summary>
  [DataMember]
  public DMD.Accent3Color? Accent3Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Accent 4.
  /// </summary>
  [DataMember]
  public DMD.Accent4Color? Accent4Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Accent 5.
  /// </summary>
  [DataMember]
  public DMD.Accent5Color? Accent5Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Accent 6.
  /// </summary>
  [DataMember]
  public DMD.Accent6Color? Accent6Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Hyperlink.
  /// </summary>
  [DataMember]
  public DMD.Hyperlink? Hyperlink
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   Followed Hyperlink.
  /// </summary>
  [DataMember]
  public DMD.FollowedHyperlinkColor? FollowedHyperlinkColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Color2Type");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
