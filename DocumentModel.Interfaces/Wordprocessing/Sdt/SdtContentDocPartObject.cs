namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartObject Class.
/// </summary>
public class SdtContentDocPartObject: ModelElement
{
  public string? DocPartGallery { get; set; }
  public string? DocPartCategory { get; set; }
  public bool? DocPartUnique { get; set; }
}