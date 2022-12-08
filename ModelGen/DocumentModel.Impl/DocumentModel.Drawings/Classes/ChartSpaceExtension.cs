namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public class ChartSpaceExtensionImpl: ModelElementImpl, ChartSpaceExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public PivotOptions? PivotOptions
  {
    get;
    set;
  }
  
  public SketchOptions? SketchOptions
  {
    get;
    set;
  }
  
  public PivotSource2? PivotSource
  {
    get;
    set;
  }
  
}
