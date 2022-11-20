namespace DocumentModel.Wordprocessing;

/// <summary>
/// Generate Thumbnail For Document On Save.
/// </summary>
public interface ISavePreviewPicture // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
