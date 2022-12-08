namespace DocumentModel.Drawings;

/// <summary>
/// Band Format.
/// </summary>
public class BandFormatImpl: ModelElementImpl, BandFormat
{
  public DocumentFormat.OpenXml.Drawing.Charts.BandFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BandFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
