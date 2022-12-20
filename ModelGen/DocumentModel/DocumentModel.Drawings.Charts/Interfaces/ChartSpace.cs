namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public partial interface ChartSpace
{
  /// <summary>
  /// Date1904.
  /// </summary>
  public Boolean? Date1904 { get; set; }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  public String? EditingLanguage { get; set; }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  public Boolean? RoundedCorners { get; set; }
  
  public Byte? Style { get; set; }
  
  public DocumentModel.Drawings.Charts.ColorMapOverride? ColorMapOverride { get; set; }
  
  public DocumentModel.Drawings.Charts.PivotSource? PivotSource { get; set; }
  
  public DocumentModel.Drawings.Charts.Protection? Protection { get; set; }
  
  public DocumentModel.Drawings.Charts.Chart? Chart { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExternalData? ExternalData { get; set; }
  
  public DocumentModel.Drawings.Charts.PrintSettings? PrintSettings { get; set; }
  
  public DocumentModel.Drawings.Charts.RelationshipIdType? UserShapesReference { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartSpaceExtensionList? ChartSpaceExtensionList { get; set; }
  
}
