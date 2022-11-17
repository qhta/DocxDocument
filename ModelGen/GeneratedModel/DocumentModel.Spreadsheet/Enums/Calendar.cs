namespace DocumentModel.Spreadsheet;

public enum Calendar
{

  [XmlEnum("none")]
  None,

  [XmlEnum("gregorian")]
  Gregorian,

  [XmlEnum("gregorianUs")]
  GregorianUs,

  [XmlEnum("japan")]
  Japan,

  [XmlEnum("taiwan")]
  Taiwan,

  [XmlEnum("korea")]
  Korea,

  [XmlEnum("hijri")]
  Hijri,

  [XmlEnum("thai")]
  Thai,

  [XmlEnum("hebrew")]
  Hebrew,

  [XmlEnum("gregorianMeFrench")]
  GregorianMiddleEastFrench,

  [XmlEnum("gregorianArabic")]
  GregorianArabic,

  [XmlEnum("gregorianXlitEnglish")]
  GregorianTransliteratedEnglish,

  [XmlEnum("gregorianXlitFrench")]
  GregorianTransliteratedFrench,
}
