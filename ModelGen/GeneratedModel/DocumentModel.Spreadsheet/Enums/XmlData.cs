namespace DocumentModel.Spreadsheet;

public enum XmlData
{
  
  [XmlEnum("string")]
  String,
  
  [XmlEnum("normalizedString")]
  NormalizedString,
  
  [XmlEnum("token")]
  Token,
  
  [XmlEnum("byte")]
  Byte,
  
  [XmlEnum("unsignedByte")]
  UnsignedByte,
  
  [XmlEnum("base64Binary")]
  Base64Binary,
  
  [XmlEnum("hexBinary")]
  HexBinary,
  
  [XmlEnum("integer")]
  Integer,
  
  [XmlEnum("positiveInteger")]
  PositiveInteger,
  
  [XmlEnum("negativeInteger")]
  NegativeInteger,
  
  [XmlEnum("nonPositiveInteger")]
  NonPositiveInteger,
  
  [XmlEnum("nonNegativeInteger")]
  NonNegativeInteger,
  
  [XmlEnum("int")]
  Int,
  
  [XmlEnum("unsignedInt")]
  UnsignedInteger,
  
  [XmlEnum("long")]
  Long,
  
  [XmlEnum("unsignedLong")]
  UnsignedLong,
  
  [XmlEnum("short")]
  Short,
  
  [XmlEnum("unsignedShort")]
  UnsignedShort,
  
  [XmlEnum("decimal")]
  Decimal,
  
  [XmlEnum("float")]
  Float,
  
  [XmlEnum("double")]
  Double,
  
  [XmlEnum("boolean")]
  Boolean,
  
  [XmlEnum("time")]
  Time,
  
  [XmlEnum("dateTime")]
  DateTime,
  
  [XmlEnum("duration")]
  Duration,
  
  [XmlEnum("date")]
  Date,
  
  [XmlEnum("gMonth")]
  Gmonth,
  
  [XmlEnum("gYear")]
  Gyear,
  
  [XmlEnum("gYearMonth")]
  GYearMonth,
  
  [XmlEnum("gDay")]
  Gday,
  
  [XmlEnum("gMonthDay")]
  GMonthDay,
  
  [XmlEnum("Name")]
  Name,
  
  [XmlEnum("QName")]
  Qname,
  
  [XmlEnum("NCName")]
  NCName,
  
  [XmlEnum("anyURI")]
  AnyURI,
  
  [XmlEnum("language")]
  Language,
  
  [XmlEnum("ID")]
  Id,
  
  [XmlEnum("IDREF")]
  IdRef,
  
  [XmlEnum("IDREFS")]
  IdRefs,
  
  [XmlEnum("ENTITY")]
  Entity,
  
  [XmlEnum("ENTITIES")]
  Entities,
  
  [XmlEnum("NOTATION")]
  Notation,
  
  [XmlEnum("NMTOKEN")]
  NMToken,
  
  [XmlEnum("NMTOKENS")]
  NMTokens,
  
  [XmlEnum("anyType")]
  AnyType,
}
