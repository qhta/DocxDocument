namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Emphasis Class.
/// </summary>
public interface IEmphasis // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Emphasis Mark Type
  /// </summary>
  public EmphasisMarkValues? Val { get ; set; }
  
}
