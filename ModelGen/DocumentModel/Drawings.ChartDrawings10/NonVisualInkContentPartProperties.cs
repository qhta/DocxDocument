namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public partial class NonVisualInkContentPartProperties: ModelElement<DXO10DCD.NonVisualInkContentPartProperties>
{
  public NonVisualInkContentPartProperties(): base(){ }
  
  public NonVisualInkContentPartProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualInkContentPartProperties(DXO10DCD.NonVisualInkContentPartProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   isComment, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsComment
  {
    get => _Element?.IsComment?.Value;
    set => _ExistingElement.IsComment = value;
  }
  
  
  /// <summary>
  ///   ContentPartLocks.
  /// </summary>
  [DataMember]
  public DMD10.ContentPartLocks? ContentPartLocks
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMD10.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
