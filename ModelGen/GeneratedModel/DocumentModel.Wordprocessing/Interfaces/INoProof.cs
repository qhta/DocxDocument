namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NoProof Class.
/// </summary>
public interface INoProof // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
