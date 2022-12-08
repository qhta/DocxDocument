namespace DocumentModel.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public class BreakImpl: ModelElementImpl, Break
{
  public DocumentFormat.OpenXml.Drawing.Break? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Break?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
}
