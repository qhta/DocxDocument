namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartObject Class.
/// </summary>
public class SdtContentDocPartObject: ModelElement
{
  public String? DocPartGallery { get; set; }

  public String? DocPartCategory { get; set; }

  public Boolean? DocPartUnique { get; set; }
}