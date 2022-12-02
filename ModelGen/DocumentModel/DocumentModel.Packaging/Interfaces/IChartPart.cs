namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public interface IChartPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public DocumentModel.Packaging.IChartColorStylePart? ChartColorStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.IChartSpace? ChartSpace { get ; set; }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public DocumentModel.Packaging.IChartStylePart? ChartStyleParts { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
