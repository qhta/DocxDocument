namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public interface IPermEnd // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  public System.Int32? Id { get ; set; }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml { get ; set; }
  
}
