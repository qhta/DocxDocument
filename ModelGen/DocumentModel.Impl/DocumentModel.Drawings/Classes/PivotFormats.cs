namespace DocumentModel.Drawings;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public class PivotFormatsImpl: ModelElementImpl, PivotFormats
{
  public DocumentFormat.OpenXml.Drawing.Charts.PivotFormats? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotFormats?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<PivotFormat>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
