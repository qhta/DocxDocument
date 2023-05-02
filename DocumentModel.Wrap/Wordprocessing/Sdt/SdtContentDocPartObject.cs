namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentDocPartObject Class.
/// </summary>
public class SdtContentDocPartObject: ModelElement
{
  public string? DocPartGallery { get; set; }

  public string? DocPartCategory { get; set; }

  public bool? DocPartUnique { get; set; }
}