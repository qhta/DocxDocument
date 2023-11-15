namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundBlurProperties Class.
/// </summary>
public partial class BackgroundBlurProperties: ModelElement<DXO21DL.BackgroundBlurProperties>
{
  public BackgroundBlurProperties(): base(){ }
  
  public BackgroundBlurProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundBlurProperties(DXO21DL.BackgroundBlurProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMD.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
