namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Blank Lines from Merged Documents.
/// </summary>
public interface IDoNotSuppressBlankLines // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
