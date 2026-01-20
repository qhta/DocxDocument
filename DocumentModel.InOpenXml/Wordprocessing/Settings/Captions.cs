namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents caption information for a WordprocessingML document, including caption definitions and automatic captioning rules.
/// </summary>
public class Captions : ModelElement<DXW.Captions>
{
  /// <summary>
  /// Contains the collection of caption format definitions for different object types.
  /// </summary>
  [OpenXmlUpdateData(nameof(UpdateCaptionDefinitionsInOpenXml))]
  public CaptionDefinitions? CaptionDefinitions { get; set; }

  /// <summary>
  /// Updates the caption definitions in the specified Open XML <see cref="DXW.Captions"/> element to match the current
  /// set of caption definitions.
  /// </summary>
  /// <remarks>This method removes all existing <see cref="DXW.Caption"/> child elements from <paramref
  /// name="wordCaptions"/> and appends new caption definitions based on the current <c>CaptionDefinitions</c>
  /// collection. If <c>CaptionDefinitions</c> is null, no changes are made.</remarks>
  /// <param name="wordCaptions">The <see cref="DXW.Captions"/> element whose child caption definitions will be replaced. Cannot be null.</param>
  public void UpdateCaptionDefinitionsInOpenXml(DXW.Captions wordCaptions)
  {
    wordCaptions.RemoveAllChildren<DXW.Caption>();
    if (CaptionDefinitions == null)
      return;
    foreach (var item in CaptionDefinitions)
    {
      var newChild = OpenXmlComplexTypeConverter.ConvertObjectToOpenXml(item, typeof(DXW.Caption));
      if (newChild is DXW.Caption caption)
        wordCaptions.AppendChild(caption);
    }
  }

  /// <summary>
  /// Contains the collection of automatic captioning rules for objects in the document.
  /// </summary>
  [OpenXmlUpdateData(nameof(UpdateAutoCaptionsInOpenXml))]
  public AutoCaptions? AutoCaptions { get; set; }

  /// <summary>
  /// Updates the specified Open XML captions collection to reflect the current set of automatic captions.
  /// </summary>
  /// <remarks>If there are no automatic captions to apply, all existing automatic captions are removed from the
  /// collection. This method does not modify other types of captions in the collection.</remarks>
  /// <param name="wordCaptions">The Open XML captions collection to update. All existing automatic captions in this collection are removed and
  /// replaced with the current set.</param>
  public void UpdateAutoCaptionsInOpenXml(DXW.Captions wordCaptions)
  {
    wordCaptions.RemoveAllChildren<DXW.AutoCaption>();
    if (AutoCaptions == null)
      return;
    foreach (var item in AutoCaptions)
    {
      var newChild = OpenXmlComplexTypeConverter.ConvertObjectToOpenXml(item, typeof(DXW.AutoCaption));
      if (newChild is DXW.AutoCaption autoCaption)
        wordCaptions.AppendChild(autoCaption);
    }
  }
}