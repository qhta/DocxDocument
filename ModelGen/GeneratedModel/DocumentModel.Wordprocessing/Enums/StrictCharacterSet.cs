namespace DocumentModel.Wordprocessing;

public enum StrictCharacterSet
{
  
  [XmlEnum("iso-8859-1")]
  chsAnsi,
  
  [XmlEnum("macintosh")]
  chsMacFfn,
  
  [XmlEnum("shift_jis")]
  chsShiftJIS,
  
  [XmlEnum("ks_c-5601-1987")]
  chsHangeul,
  
  [XmlEnum("KS_C-5601-1992")]
  chsJohab,
  
  [XmlEnum("GBK")]
  chsGB2312,
  
  [XmlEnum("Big5")]
  chsChinese5,
  
  [XmlEnum("windows-1253")]
  chsGreek,
  
  [XmlEnum("iso-8859-9")]
  chsTurkish,
  
  [XmlEnum("windows-1258")]
  chsVietnamese,
  
  [XmlEnum("windows-1255")]
  chsHebrew,
  
  [XmlEnum("windows-1256")]
  chsArabic,
  
  [XmlEnum("windows-1257")]
  chsBaltic,
  
  [XmlEnum("windows-1251")]
  chsRussian,
  
  [XmlEnum("windows-874")]
  chsThai,
  
  [XmlEnum("windows-1250")]
  chsEastEurope,
}
