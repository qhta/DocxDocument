namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundNormalProperties Class.
/// </summary>
public partial class BackgroundNormalProperties: ModelElement<DXO21DL.BackgroundNormalProperties>
{
  public BackgroundNormalProperties(): base(){ }
  
  public BackgroundNormalProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundNormalProperties(DXO21DL.BackgroundNormalProperties openXmlElement): base(openXmlElement) { }
  
  
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
