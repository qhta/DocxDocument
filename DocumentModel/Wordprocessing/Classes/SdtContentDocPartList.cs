namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartList Class.
/// </summary>
public record SdtContentDocPartList
{
  public String? DocPartGallery { get; set; }

  public String? DocPartCategory { get; set; }

  public Boolean? DocPartUnique { get; set; }
}