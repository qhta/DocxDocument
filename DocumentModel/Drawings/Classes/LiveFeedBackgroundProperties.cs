namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public class LiveFeedBackgroundProperties: ModelElement
{
  public BackgroundNormalProperties? BackgroundNormalProperties { get; set; }

  public BackgroundRemovedProperties? BackgroundRemovedProperties { get; set; }

  public BackgroundBlurProperties? BackgroundBlurProperties { get; set; }

  public BackgroundCustomProperties? BackgroundCustomProperties { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}