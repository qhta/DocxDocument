namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public interface IChartDrawingPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.IUserShapes? UserShapes { get ; set; }
  
}
