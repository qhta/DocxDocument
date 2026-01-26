namespace DocumentModel.Vml;
/// <summary>
///   Defines the ImageData Class.
/// </summary>
[OpenXmlType(typeof(DXV.ImageData))]
public partial class ImageData : ModelElement<DXV.ImageData>
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.Id))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Image Transparency Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.ChromAKey))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? ChromAKey { get => _ChromAKey; set => UpdateField(ref _ChromAKey, value, nameof(ChromAKey)); }

 private string? _ChromAKey;
 /// <summary>
 ///   Image Left Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.CropLeft))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? CropLeft { get => _CropLeft; set => UpdateField(ref _CropLeft, value, nameof(CropLeft)); }

 private string? _CropLeft;
 /// <summary>
 ///   Image Top Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.CropTop))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? CropTop { get => _CropTop; set => UpdateField(ref _CropTop, value, nameof(CropTop)); }

 private string? _CropTop;
 /// <summary>
 ///   Image Right Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.CropRight))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? CropRight { get => _CropRight; set => UpdateField(ref _CropRight, value, nameof(CropRight)); }

 private string? _CropRight;
 /// <summary>
 ///   Image Bottom Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.CropBottom))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? CropBottom { get => _CropBottom; set => UpdateField(ref _CropBottom, value, nameof(CropBottom)); }

 private string? _CropBottom;
 /// <summary>
 ///   Image Intensity
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.Gain))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? Gain { get => _Gain; set => UpdateField(ref _Gain, value, nameof(Gain)); }

 private string? _Gain;
 /// <summary>
 ///   Image Brightness
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.BlackLevel))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? BlackLevel { get => _BlackLevel; set => UpdateField(ref _BlackLevel, value, nameof(BlackLevel)); }

 private string? _BlackLevel;
 /// <summary>
 ///   Image Gamma Correction
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.Gamma))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? Gamma { get => _Gamma; set => UpdateField(ref _Gamma, value, nameof(Gamma)); }

 private string? _Gamma;
 /// <summary>
 ///   Image Grayscale Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.Grayscale))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public Boolean Grayscale { get => _Grayscale; set => UpdateField(ref _Grayscale, value, nameof(Grayscale)); }

 private Boolean _Grayscale;
 /// <summary>
 ///   Image Bilevel Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.BiLevel))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public bool? BiLevel { get => _BiLevel; set => UpdateField(ref _BiLevel, value, nameof(BiLevel)); }

 private bool? _BiLevel;
 /// <summary>
 ///   Embossed Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.EmbossColor))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? EmbossColor { get => _EmbossColor; set => UpdateField(ref _EmbossColor, value, nameof(EmbossColor)); }

 private string? _EmbossColor;
 /// <summary>
 ///   Black Recoloring Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.RecolorTarget))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? RecolorTarget { get => _RecolorTarget; set => UpdateField(ref _RecolorTarget, value, nameof(RecolorTarget)); }

 private string? _RecolorTarget;
 /// <summary>
 ///   Image Data Title
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.Title))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   Detect Mouse Click
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.DetectMouseClick))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public bool? DetectMouseClick { get => _DetectMouseClick; set => UpdateField(ref _DetectMouseClick, value, nameof(DetectMouseClick)); }

 private bool? _DetectMouseClick;
 /// <summary>
 ///   Relationship to Part
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.RelId))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? RelId { get => _RelId; set => UpdateField(ref _RelId, value, nameof(RelId)); }

 private string? _RelId;
 /// <summary>
 ///   Explicit Relationship to Image Data
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.RelationshipId))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? RelationshipId { get => _RelationshipId; set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId)); }

 private string? _RelationshipId;
 /// <summary>
 ///   Explicit Relationship to Alternate Image Data
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.Picture))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? Picture { get => _Picture; set => UpdateField(ref _Picture, value, nameof(Picture)); }

 private string? _Picture;
 /// <summary>
 ///   Explicit Relationship to IHyperlink Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageData.RelHref))]
 [OpenXmlElement(typeof(DXV.ImageData))]
 public string? RelHref { get => _RelHref; set => UpdateField(ref _RelHref, value, nameof(RelHref)); }

 private string? _RelHref;
}