namespace DocumentModel.Drawings;

/// <summary>
/// Band Format.
/// </summary>
public class BandFormatImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>, BandFormat
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
