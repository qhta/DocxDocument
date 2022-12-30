namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public partial class DLblExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelFieldTable? DataLabelFieldTable { get; set; }
  
  public Boolean? ExceptionForSave { get; set; }
  
  public Boolean? ShowDataLabelsRange { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties3? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout3? Layout { get; set; }
  
}
