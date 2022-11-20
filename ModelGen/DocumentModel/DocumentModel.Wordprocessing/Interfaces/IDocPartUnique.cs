namespace DocumentModel.Wordprocessing;

/// <summary>
/// Built-In Document Part.
/// </summary>
public interface IDocPartUnique // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
