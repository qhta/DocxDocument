namespace DocumentModel.Wordprocessing;

/// <summary>
/// Maintain Link to Existing File.
/// </summary>
public interface ILinkedToFile // : DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnlyValues? Val { get ; set; }
  
}
