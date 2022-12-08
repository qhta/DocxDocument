namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public class ChartPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartPart
{
  public new DocumentFormat.OpenXml.Packaging.ChartPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace2? ChartSpace
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public ChartStylePart? ChartStyleParts
  {
    get;
    set;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  public ImagePart? ImageParts
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
