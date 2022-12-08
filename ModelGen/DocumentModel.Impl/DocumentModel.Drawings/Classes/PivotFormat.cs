namespace DocumentModel.Drawings;

/// <summary>
/// Pivot Format.
/// </summary>
public class PivotFormatImpl: ModelElementImpl, PivotFormat
{
  public DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotFormat?)_OpenXmlElement;
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
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker1? Marker
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DataLabel3? DataLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
