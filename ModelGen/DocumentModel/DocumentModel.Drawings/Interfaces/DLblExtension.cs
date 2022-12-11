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
  
  public ShapeProperties? ShapeProperties { get ; set; }
  
  public Layout? Layout { get ; set; }
  
}
