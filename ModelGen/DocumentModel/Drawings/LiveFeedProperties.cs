namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LiveFeedProperties Class.
/// </summary>
public partial class LiveFeedProperties: ModelElement<DXO21DL.LiveFeedProperties>
{
  public LiveFeedProperties(): base(){ }
  
  public LiveFeedProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LiveFeedProperties(DXO21DL.LiveFeedProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LiveFeedBackgroundProperties.
  /// </summary>
  [DataMember]
  public DMD.LiveFeedBackgroundProperties? LiveFeedBackgroundProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
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
