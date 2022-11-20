namespace DocumentModel.Wordprocessing;

/// <summary>
/// Record Is Included in Mail Merge.
/// </summary>
public interface IActive // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
