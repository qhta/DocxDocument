namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents caption information for a WordprocessingML document, including caption definitions and automatic captioning rules.
/// </summary>
public class Captions : ModelElement<DXW.Captions>
{
  /// <summary>
  /// Contains the collection of caption format definitions for different object types.
  /// </summary>
  public CaptionDefinitions? CaptionDefinitions { get; set; }

  /// <summary>
  /// Contains the collection of automatic captioning rules for objects in the document.
  /// </summary>
  public AutoCaptions? AutoCaptions { get; set; }
}