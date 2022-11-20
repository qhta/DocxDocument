namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Highlight Class.
/// </summary>
public interface IHighlight // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Highlighting Color
  /// </summary>
  public HighlightColorValues? Val { get ; set; }
  
}
