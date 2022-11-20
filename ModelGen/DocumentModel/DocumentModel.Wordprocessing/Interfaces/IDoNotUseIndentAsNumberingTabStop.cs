namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Hanging Indent When Creating Tab Stop After Numbering.
/// </summary>
public interface IDoNotUseIndentAsNumberingTabStop // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
