namespace DocumentModel.Spreadsheet;

public enum DataValidationImeMode
{
  
  [XmlEnum("noControl")]
  NoControl,
  
  [XmlEnum("off")]
  Off,
  
  [XmlEnum("on")]
  On,
  
  [XmlEnum("disabled")]
  Disabled,
  
  [XmlEnum("hiragana")]
  Hiragana,
  
  [XmlEnum("fullKatakana")]
  FullKatakana,
  
  [XmlEnum("halfKatakana")]
  HalfKatakana,
  
  [XmlEnum("fullAlpha")]
  FullAlpha,
  
  [XmlEnum("halfAlpha")]
  HalfAlpha,
  
  [XmlEnum("fullHangul")]
  FullHangul,
  
  [XmlEnum("halfHangul")]
  HalfHangul,
}
