namespace DocumentModel.Wordprocessing;

/// <summary>
/// Invalidated Field Cache.
/// </summary>
public interface IDirty // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
