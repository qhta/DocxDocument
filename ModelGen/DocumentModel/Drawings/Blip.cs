namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of an image (binary large image or picture) and contains a reference to the image data.
/// </summary>
public partial class Blip: ModelElement<DXD.Blip>
{
  public Blip(): base(){ }
  
  public Blip(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blip(DXD.Blip openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [DataMember]
  public String? Embed
  {
    get => _Element?.Embed;
    set => _ExistingElement.Embed = value;
  }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [DataMember]
  public String? Link
  {
    get => _Element?.Link;
    set => _ExistingElement.Link = value;
  }
  
  [DataMember]
  public DMD.BlipExtensionList? BlipExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
