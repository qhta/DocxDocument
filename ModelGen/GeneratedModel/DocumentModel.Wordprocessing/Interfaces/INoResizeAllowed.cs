namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frame Cannot Be Resized.
/// </summary>
public interface INoResizeAllowed // : DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnly? Val { get ; set; }
  
}
