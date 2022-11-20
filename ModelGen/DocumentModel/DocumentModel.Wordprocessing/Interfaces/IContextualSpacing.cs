namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContextualSpacing Class.
/// </summary>
public interface IContextualSpacing // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
