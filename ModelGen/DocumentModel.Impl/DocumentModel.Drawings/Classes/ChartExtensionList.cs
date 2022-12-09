namespace DocumentModel.Drawings;

/// <summary>
/// Extensibility container.
/// </summary>
public class ChartExtensionListImpl: ModelElementImpl, ChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DataDisplayOptions16>? DataDisplayOptions16s
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
