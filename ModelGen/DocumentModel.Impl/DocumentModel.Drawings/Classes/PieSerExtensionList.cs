namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public class PieSerExtensionListImpl: ModelElementImpl, PieSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<PieSerExtension>? PieSerExtensions
  {
    get;
    set;
  }
  
}
