namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DLblExtension Class.
/// </summary>
public class DLblExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public DataLabelFieldTable? DataLabelFieldTable { get; set; }

  public Boolean? ExceptionForSave { get; set; }

  public Boolean? ShowDataLabelsRange { get; set; }

  public ShapeProperties3? ShapeProperties { get; set; }

  public Layout3? Layout { get; set; }
}