namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public class ChartStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartStylePart
{
  public new DocumentFormat.OpenXml.Packaging.ChartStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartStylePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartStyle? ChartStyle
  {
    get;
    set;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
