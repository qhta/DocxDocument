namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public interface DLblExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ExceptionForSave { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public ShapeProperties2? ShapeProperties { get ; set; }
  
  public Layout2? Layout { get ; set; }
  
}
