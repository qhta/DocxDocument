namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Contextual Spacing of Paragraphs in Tables.
/// </summary>
public interface IAllowSpaceOfSameStyleInTable // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
