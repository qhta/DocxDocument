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
  
  public ChartSpaceExtensionImpl(): base() {}
  
  public ChartSpaceExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public PivotOptions? PivotOptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SketchOptions? SketchOptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PivotSource? PivotSource
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
