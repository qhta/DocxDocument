namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentDocPartList Class.
/// </summary>
public class SdtContentDocPartList: ModelElement
{
  public string? DocPartGallery { get; set; }

  public string? DocPartCategory { get; set; }

  public bool? DocPartUnique { get; set; }
}