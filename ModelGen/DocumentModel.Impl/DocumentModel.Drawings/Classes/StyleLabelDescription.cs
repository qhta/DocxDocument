namespace DocumentModel.Drawings;

/// <summary>
/// Style Label Description.
/// </summary>
public class StyleLabelDescriptionImpl: ModelElementImpl, StyleLabelDescription
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Natural Language
  /// </summary>
  public String? Language
  {
    get;
    set;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
