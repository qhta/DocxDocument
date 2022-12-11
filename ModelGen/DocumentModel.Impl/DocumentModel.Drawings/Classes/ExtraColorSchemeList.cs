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
  
  public ExtraColorSchemeListImpl(): base() {}
  
  public ExtraColorSchemeListImpl(DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<ExtraColorScheme>? ExtraColorSchemes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
