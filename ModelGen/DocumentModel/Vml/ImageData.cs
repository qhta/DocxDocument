namespace DocumentModel.Vml;


/// <summary>
///   Defines the ImageData Class.
/// </summary>
public partial class ImageData: ModelElement<DXV.ImageData>
{
  public ImageData(): base(){ }
  
  public ImageData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageData(DXV.ImageData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   Image Transparency Color
  /// </summary>
  [DataMember]
  public String? ChromAKey
  {
    get => _Element?.ChromAKey;
    set => _ExistingElement.ChromAKey = value;
  }
  
  
  /// <summary>
  ///   Image Left Crop
  /// </summary>
  [DataMember]
  public String? CropLeft
  {
    get => _Element?.CropLeft;
    set => _ExistingElement.CropLeft = value;
  }
  
  
  /// <summary>
  ///   Image Top Crop
  /// </summary>
  [DataMember]
  public String? CropTop
  {
    get => _Element?.CropTop;
    set => _ExistingElement.CropTop = value;
  }
  
  
  /// <summary>
  ///   Image Right Crop
  /// </summary>
  [DataMember]
  public String? CropRight
  {
    get => _Element?.CropRight;
    set => _ExistingElement.CropRight = value;
  }
  
  
  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  [DataMember]
  public String? CropBottom
  {
    get => _Element?.CropBottom;
    set => _ExistingElement.CropBottom = value;
  }
  
  
  /// <summary>
  ///   Image Intensity
  /// </summary>
  [DataMember]
  public String? Gain
  {
    get => _Element?.Gain;
    set => _ExistingElement.Gain = value;
  }
  
  
  /// <summary>
  ///   Image Brightness
  /// </summary>
  [DataMember]
  public String? BlackLevel
  {
    get => _Element?.BlackLevel;
    set => _ExistingElement.BlackLevel = value;
  }
  
  
  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  [DataMember]
  public String? Gamma
  {
    get => _Element?.Gamma;
    set => _ExistingElement.Gamma = value;
  }
  
  
  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  [DataMember]
  public Boolean? Grayscale
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  [DataMember]
  public Boolean? BiLevel
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Embossed Color
  /// </summary>
  [DataMember]
  public String? EmbossColor
  {
    get => _Element?.EmbossColor;
    set => _ExistingElement.EmbossColor = value;
  }
  
  
  /// <summary>
  ///   Black Recoloring Color
  /// </summary>
  [DataMember]
  public String? RecolorTarget
  {
    get => _Element?.RecolorTarget;
    set => _ExistingElement.RecolorTarget = value;
  }
  
  
  /// <summary>
  ///   Image Data Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [DataMember]
  public Boolean? DetectMouseClick
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? RelId
  {
    get => _Element?.RelId;
    set => _ExistingElement.RelId = value;
  }
  
  
  /// <summary>
  ///   Explicit Relationship to Image Data
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get => _Element?.RelationshipId;
    set => _ExistingElement.RelationshipId = value;
  }
  
  
  /// <summary>
  ///   Explicit Relationship to Alternate Image Data
  /// </summary>
  [DataMember]
  public String? Picture
  {
    get => _Element?.Picture;
    set => _ExistingElement.Picture = value;
  }
  
  
  /// <summary>
  ///   Explicit Relationship to Hyperlink Target
  /// </summary>
  [DataMember]
  public String? RelHref
  {
    get => _Element?.RelHref;
    set => _ExistingElement.RelHref = value;
  }
  
}
