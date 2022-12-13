namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public interface DLblExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ExceptionForSave { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawings13.Charts.Layout? Layout { get ; set; }
  
}
