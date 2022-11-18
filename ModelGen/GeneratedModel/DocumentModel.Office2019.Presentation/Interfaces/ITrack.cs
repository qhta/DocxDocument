namespace DocumentModel.Office2019.Presentation;

/// <summary>
/// Defines the Track Class.
/// </summary>
public interface ITrack // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// lang, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Lang { get ; set; }
  
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public string? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public string? Link { get ; set; }
  
}
