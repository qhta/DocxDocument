namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public class ExtraColorSchemeListImpl: ModelElementImpl, ExtraColorSchemeList
{
  public DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ExtraColorScheme>? ExtraColorSchemes
  {
    get;
    set;
  }
  
}
