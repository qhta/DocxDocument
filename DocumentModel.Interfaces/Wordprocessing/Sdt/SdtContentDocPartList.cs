namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartList Class.
/// </summary>
public interface SdtContentDocPartList: IModelElement
{
  public string? DocPartGallery { get; set; }
  public string? DocPartCategory { get; set; }
  public bool? DocPartUnique { get; set; }
}