namespace DocumentModel.Drawings;
/// <summary>
///   Represents background properties for a live feed, including normal, removed, blur, custom, and extension settings.
/// </summary>
public partial class LiveFeedBackgroundProperties : ModelElement<DXO21DL.LiveFeedBackgroundProperties>
{
  /// <summary>
  ///   Properties for a normal background in the live feed.
  /// </summary>
  public BackgroundNormalProperties? BackgroundNormalProperties { get; set; }
  /// <summary>
  ///   Properties for a removed background in the live feed.
  /// </summary>
  public BackgroundRemovedProperties? BackgroundRemovedProperties { get; set; }
  /// <summary>
  ///   Properties for a blurred background in the live feed.
  /// </summary>
  public BackgroundBlurProperties? BackgroundBlurProperties { get; set; }
  /// <summary>
  ///   Properties for a custom background in the live feed.
  /// </summary>
  public BackgroundCustomProperties? BackgroundCustomProperties { get; set; }
  /// <summary>
  ///   List of extension elements for additional background properties.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}