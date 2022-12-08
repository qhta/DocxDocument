namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionList2Impl: ModelElementImpl, ExtensionList2
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension2>? Extension2s
  {
    get;
    set;
  }
  
}
