namespace DocumentModel.Wordprocessing;

public enum TextBoxFormField
{
  
  [XmlEnum("regular")]
  Regular,
  
  [XmlEnum("number")]
  Number,
  
  [XmlEnum("date")]
  Date,
  
  [XmlEnum("currentTime")]
  CurrentTime,
  
  [XmlEnum("currentDate")]
  CurrentDate,
  
  [XmlEnum("calculated")]
  Calculated,
}
