namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public interface IPermEnd // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  public int? Id { get ; set; }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXml? DisplacedByCustomXml { get ; set; }
  
}
