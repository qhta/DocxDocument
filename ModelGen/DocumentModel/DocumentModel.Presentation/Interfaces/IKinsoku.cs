namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Kinsoku Class.
/// </summary>
public interface IKinsoku // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// Invalid Kinsoku Start Characters
  /// </summary>
  public String? InvalidStartChars { get ; set; }
  
  /// <summary>
  /// Invalid Kinsoku End Characters
  /// </summary>
  public String? InvalidEndChars { get ; set; }
  
}
