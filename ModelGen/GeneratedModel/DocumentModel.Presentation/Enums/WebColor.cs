namespace DocumentModel.Presentation;

public enum WebColor
{

  [XmlEnum("none")]
  None,

  [XmlEnum("browser")]
  Browser,

  [XmlEnum("presentationText")]
  PresentationText,

  [XmlEnum("presentationAccent")]
  PresentationAccent,

  [XmlEnum("whiteTextOnBlack")]
  WhiteTextOnBlack,

  [XmlEnum("blackTextOnWhite")]
  BlackTextOnWhite,
}
