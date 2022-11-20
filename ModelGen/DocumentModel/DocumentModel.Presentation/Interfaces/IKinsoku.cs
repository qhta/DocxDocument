namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Kinsoku Class.
/// </summary>
public interface IKinsoku // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public string? Language { get ; set; }
  
  /// <summary>
  /// Invalid Kinsoku Start Characters
  /// </summary>
  public string? InvalidStartChars { get ; set; }
  
  /// <summary>
  /// Invalid Kinsoku End Characters
  /// </summary>
  public string? InvalidEndChars { get ; set; }
  
}
