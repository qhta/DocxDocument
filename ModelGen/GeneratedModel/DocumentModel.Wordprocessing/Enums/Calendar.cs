namespace DocumentModel.Wordprocessing;

public enum Calendar
{
  
  [XmlEnum("gregorian")]
  Gregorian,
  
  [XmlEnum("hijri")]
  Hijri,
  
  [XmlEnum("umalqura")]
  Umalqura,
  
  [XmlEnum("hebrew")]
  Hebrew,
  
  [XmlEnum("taiwan")]
  Taiwan,
  
  [XmlEnum("japan")]
  Japan,
  
  [XmlEnum("thai")]
  Thai,
  
  [XmlEnum("korea")]
  Korea,
  
  [XmlEnum("saka")]
  Saka,
  
  [XmlEnum("gregorianXlitEnglish")]
  GregorianTransliteratedEnglish,
  
  [XmlEnum("gregorianXlitFrench")]
  GregorianTransliteratedFrench,
  
  [XmlEnum("gregorianUs")]
  GregorianUs,
  
  [XmlEnum("gregorianMeFrench")]
  GregorianMeFrench,
  
  [XmlEnum("gregorianArabic")]
  GregorianArabic,
  
  [XmlEnum("none")]
  None,
}
