namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundCustomProperties Class.
/// </summary>
public partial class BackgroundCustomProperties: ModelElement<DXO21DL.BackgroundCustomProperties>
{
  public BackgroundCustomProperties(): base(){ }
  
  public BackgroundCustomProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundCustomProperties(DXO21DL.BackgroundCustomProperties openXmlElement): base(openXmlElement) { }
  
  
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
