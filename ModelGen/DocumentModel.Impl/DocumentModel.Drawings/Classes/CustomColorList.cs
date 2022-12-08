namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public class CustomColorListImpl: ModelElementImpl, CustomColorList
{
  public DocumentFormat.OpenXml.Drawing.CustomColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CustomColorList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<CustomColor>? CustomColors
  {
    get;
    set;
  }
  
}
