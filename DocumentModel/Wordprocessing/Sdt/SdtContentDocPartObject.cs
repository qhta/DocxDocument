namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentDocPartObject Class.
/// </summary>
public class SdtContentDocPartObject: ModelElement
{
  public String? DocPartGallery { get; set; }

  public String? DocPartCategory { get; set; }

  public Boolean? DocPartUnique { get; set; }
}