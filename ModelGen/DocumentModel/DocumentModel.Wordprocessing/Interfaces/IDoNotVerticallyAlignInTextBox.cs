namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Vertical Alignment in Textboxes.
/// </summary>
public interface IDoNotVerticallyAlignInTextBox // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
