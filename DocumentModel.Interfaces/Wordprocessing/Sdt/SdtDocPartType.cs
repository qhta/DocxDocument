namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public class SdtDocPartType: ModelElement
{
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
  public string? DocPartGallery { get; set; }
  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
  public string? DocPartCategory { get; set; }
  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
  public bool? DocPartUnique { get; set; }
}