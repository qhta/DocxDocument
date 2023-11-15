namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundRemovedProperties Class.
/// </summary>
public partial class BackgroundRemovedProperties: ModelElement<DXO21DL.BackgroundRemovedProperties>
{
  public BackgroundRemovedProperties(): base(){ }
  
  public BackgroundRemovedProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundRemovedProperties(DXO21DL.BackgroundRemovedProperties openXmlElement): base(openXmlElement) { }
  
  
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
