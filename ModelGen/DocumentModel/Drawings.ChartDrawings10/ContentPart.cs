namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public partial class ContentPart: ModelElement<DXO10DCD.ContentPart>
{
  public ContentPart(): base(){ }
  
  public ContentPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContentPart(DXO10DCD.ContentPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get => _Element?.RelationshipId;
    set => _ExistingElement.RelationshipId = value;
  }
  
  
  /// <summary>
  ///   NonVisualContentPartProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.NonVisualContentPartProperties? NonVisualContentPartProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ApplicationNonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Transform2D.
  /// </summary>
  [DataMember]
  public DMDCD10.Transform2D? Transform2D
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD10.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
