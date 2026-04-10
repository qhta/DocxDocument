namespace DocumentModel.Drawings;
/// <summary>
///   Represents background properties for a live feed, including normal, removed, blur, custom, and extension settings.
/// </summary>
[OpenXmlType(typeof(DXO21DL.LiveFeedBackgroundProperties))]
[XmlRoot("LiveFeedBackgroundProperties", Namespace = "DocumentModel.Drawings")]
public partial class LiveFeedBackgroundProperties : ModelElement<DXO21DL.LiveFeedBackgroundProperties>
{
 /// <summary>
 ///   Properties for a normal background in the live feed.
 /// </summary>
 public BackgroundNormalProperties? BackgroundNormalProperties { get => _BackgroundNormalProperties; set => UpdateField(ref _BackgroundNormalProperties, value, nameof(BackgroundNormalProperties)); }

 private BackgroundNormalProperties? _BackgroundNormalProperties;
 /// <summary>
 ///   Properties for a removed background in the live feed.
 /// </summary>
 public BackgroundRemovedProperties? BackgroundRemovedProperties { get => _BackgroundRemovedProperties; set => UpdateField(ref _BackgroundRemovedProperties, value, nameof(BackgroundRemovedProperties)); }

 private BackgroundRemovedProperties? _BackgroundRemovedProperties;
 /// <summary>
 ///   Properties for a blurred background in the live feed.
 /// </summary>
 public BackgroundBlurProperties? BackgroundBlurProperties { get => _BackgroundBlurProperties; set => UpdateField(ref _BackgroundBlurProperties, value, nameof(BackgroundBlurProperties)); }

 private BackgroundBlurProperties? _BackgroundBlurProperties;
 /// <summary>
 ///   Properties for a custom background in the live feed.
 /// </summary>
 public BackgroundCustomProperties? BackgroundCustomProperties { get => _BackgroundCustomProperties; set => UpdateField(ref _BackgroundCustomProperties, value, nameof(BackgroundCustomProperties)); }

 private BackgroundCustomProperties? _BackgroundCustomProperties;
 /// <summary>
 ///   List of extension elements for additional background properties.
 /// </summary>
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}