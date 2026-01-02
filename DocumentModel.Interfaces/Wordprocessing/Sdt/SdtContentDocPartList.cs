namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartList Class.
/// </summary>
public class SdtContentDocPartList: ModelElement
{
  public string? DocPartGallery { get; set; }
  public string? DocPartCategory { get; set; }
  public bool? DocPartUnique { get; set; }
}