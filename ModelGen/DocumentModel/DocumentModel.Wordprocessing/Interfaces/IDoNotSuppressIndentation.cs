namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
/// </summary>
public interface IDoNotSuppressIndentation // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
