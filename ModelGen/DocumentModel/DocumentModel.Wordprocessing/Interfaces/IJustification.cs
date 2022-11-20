namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Justification Class.
/// </summary>
public interface IJustification // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Alignment Type
  /// </summary>
  public DocumentModel.Wordprocessing.JustificationValues? Val { get ; set; }
  
}
