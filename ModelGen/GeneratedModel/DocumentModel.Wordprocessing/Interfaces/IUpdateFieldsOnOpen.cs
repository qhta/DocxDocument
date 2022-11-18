namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatically Recalculate Fields on Open.
/// </summary>
public interface IUpdateFieldsOnOpen // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
