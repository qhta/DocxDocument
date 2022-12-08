namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public class ChartColorStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartColorStylePart
{
  public new DocumentFormat.OpenXml.Packaging.ChartColorStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartColorStylePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ColorStyle? ColorStyle
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
