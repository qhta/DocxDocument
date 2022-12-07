namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public class ChartSpaceExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>, ChartSpaceExtension
{
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
