namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for the definition of default shape, line, and textbox formatting properties.  An application can use this information to format a shape (or text) initially on insertion into a document.
/// </summary>
public partial class ObjectDefaults: ModelElement<DXD.ObjectDefaults>
{
  public ObjectDefaults(): base(){ }
  
  public ObjectDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ObjectDefaults(DXD.ObjectDefaults openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape Default.
  /// </summary>
  [DataMember]
  public DMD.ShapeDefault? ShapeDefault
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType");
  }
  
  
  /// <summary>
  ///   Line Default.
  /// </summary>
  [DataMember]
  public DMD.LineDefault? LineDefault
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType");
  }
  
  
  /// <summary>
  ///   Text Default.
  /// </summary>
  [DataMember]
  public DMD.TextDefault? TextDefault
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
