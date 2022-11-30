namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public interface IChartSpace // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Date1904.
  /// </summary>
  public System.Boolean? Date1904 { get ; set; }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  public System.String? EditingLanguage { get ; set; }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  public System.Boolean? RoundedCorners { get ; set; }
  
  public System.Byte? Style { get ; set; }
  
  public DocumentModel.Drawing.Charts.IColorMapOverride? ColorMapOverride { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPivotSource? PivotSource { get ; set; }
  
  public DocumentModel.Drawing.Charts.IProtection? Protection { get ; set; }
  
  public DocumentModel.Drawing.Charts.IChart? Chart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExternalData? ExternalData { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPrintSettings? PrintSettings { get ; set; }
  
  public DocumentModel.Drawing.Charts.IRelationshipIdType? UserShapesReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.IChartSpaceExtensionList? ChartSpaceExtensionList { get ; set; }
  
}
