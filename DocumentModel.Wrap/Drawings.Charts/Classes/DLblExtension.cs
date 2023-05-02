namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DLblExtension Class.
/// </summary>
public class DLblExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public DataLabelFieldTable? DataLabelFieldTable { get; set; }

  public bool? ExceptionForSave { get; set; }

  public bool? ShowDataLabelsRange { get; set; }

  public ShapeProperties3? ShapeProperties { get; set; }

  public Layout3? Layout { get; set; }
}