namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public class ExtendedChartPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ExtendedChartPart
{
  public new DocumentFormat.OpenXml.Packaging.ExtendedChartPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ExtendedChartPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace1? ChartSpace
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
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
  /// Gets the ImageParts of the ExtendedChartPart
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
