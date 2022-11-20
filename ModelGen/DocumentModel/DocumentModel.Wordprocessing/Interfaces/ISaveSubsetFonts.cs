namespace DocumentModel.Wordprocessing;

/// <summary>
/// Subset Fonts When Embedding.
/// </summary>
public interface ISaveSubsetFonts // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
