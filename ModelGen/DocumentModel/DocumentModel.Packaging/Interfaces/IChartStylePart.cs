namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public interface IChartStylePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IChartStyle? ChartStyle { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
