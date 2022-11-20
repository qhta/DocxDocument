namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
/// </summary>
public interface IForgetLastTabAlignment // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
