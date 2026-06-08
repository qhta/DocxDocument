namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public class SdtDocPartType: ModelElement
{
  /// <summary>
  ///   IDocument Part Gallery Filter.
  /// </summary>
  public string? DocPartGallery { get; set; }

  /// <summary>
  ///   IDocument Part ICategory Filter.
  /// </summary>
  public string? DocPartCategory { get; set; }

  /// <summary>
  ///   Built-In IDocument Part.
  /// </summary>
  public bool? DocPartUnique { get; set; }
}
