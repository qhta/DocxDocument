namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Data Types
/// </summary>
public enum XmlDataValues
{
  /// <summary>
  /// String.
  /// </summary>
  [XmlEnum("string")]
  String,
  
  /// <summary>
  /// Normalized String.
  /// </summary>
  [XmlEnum("normalizedString")]
  NormalizedString,
  
  /// <summary>
  /// Token.
  /// </summary>
  [XmlEnum("token")]
  Token,
  
  /// <summary>
  /// Byte.
  /// </summary>
  [XmlEnum("byte")]
  Byte,
  
  /// <summary>
  /// Unsigned Byte.
  /// </summary>
  [XmlEnum("unsignedByte")]
  UnsignedByte,
  
  /// <summary>
  /// Base 64 Encoded Binary.
  /// </summary>
  [XmlEnum("base64Binary")]
  Base64Binary,
  
  /// <summary>
  /// Hex Binary.
  /// </summary>
  [XmlEnum("hexBinary")]
  HexBinary,
  
  /// <summary>
  /// Integer.
  /// </summary>
  [XmlEnum("integer")]
  Integer,
  
  /// <summary>
  /// Positive Integer.
  /// </summary>
  [XmlEnum("positiveInteger")]
  PositiveInteger,
  
  /// <summary>
  /// Negative Integer.
  /// </summary>
  [XmlEnum("negativeInteger")]
  NegativeInteger,
  
  /// <summary>
  /// Non Positive Integer.
  /// </summary>
  [XmlEnum("nonPositiveInteger")]
  NonPositiveInteger,
  
  /// <summary>
  /// Non Negative Integer.
  /// </summary>
  [XmlEnum("nonNegativeInteger")]
  NonNegativeInteger,
  
  /// <summary>
  /// Integer.
  /// </summary>
  [XmlEnum("int")]
  Int,
  
  /// <summary>
  /// Unsigned Integer.
  /// </summary>
  [XmlEnum("unsignedInt")]
  UnsignedInteger,
  
  /// <summary>
  /// Long.
  /// </summary>
  [XmlEnum("long")]
  Long,
  
  /// <summary>
  /// Unsigned Long.
  /// </summary>
  [XmlEnum("unsignedLong")]
  UnsignedLong,
  
  /// <summary>
  /// Short.
  /// </summary>
  [XmlEnum("short")]
  Short,
  
  /// <summary>
  /// Unsigned Short.
  /// </summary>
  [XmlEnum("unsignedShort")]
  UnsignedShort,
  
  /// <summary>
  /// Decimal.
  /// </summary>
  [XmlEnum("decimal")]
  Decimal,
  
  /// <summary>
  /// Float.
  /// </summary>
  [XmlEnum("float")]
  Float,
  
  /// <summary>
  /// Double.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Boolean.
  /// </summary>
  [XmlEnum("boolean")]
  Boolean,
  
  /// <summary>
  /// Time.
  /// </summary>
  [XmlEnum("time")]
  Time,
  
  /// <summary>
  /// Date Time.
  /// </summary>
  [XmlEnum("dateTime")]
  DateTime,
  
  /// <summary>
  /// Duration.
  /// </summary>
  [XmlEnum("duration")]
  Duration,
  
  /// <summary>
  /// Date.
  /// </summary>
  [XmlEnum("date")]
  Date,
  
  /// <summary>
  /// gMonth.
  /// </summary>
  [XmlEnum("gMonth")]
  Gmonth,
  
  /// <summary>
  /// gYear.
  /// </summary>
  [XmlEnum("gYear")]
  Gyear,
  
  /// <summary>
  /// gYearMonth.
  /// </summary>
  [XmlEnum("gYearMonth")]
  GYearMonth,
  
  /// <summary>
  /// gDay.
  /// </summary>
  [XmlEnum("gDay")]
  Gday,
  
  /// <summary>
  /// gMonthDays.
  /// </summary>
  [XmlEnum("gMonthDay")]
  GMonthDay,
  
  /// <summary>
  /// Name.
  /// </summary>
  [XmlEnum("Name")]
  Name,
  
  /// <summary>
  /// Qname.
  /// </summary>
  [XmlEnum("QName")]
  Qname,
  
  /// <summary>
  /// NCName.
  /// </summary>
  [XmlEnum("NCName")]
  NCName,
  
  /// <summary>
  /// Any URI.
  /// </summary>
  [XmlEnum("anyURI")]
  AnyURI,
  
  /// <summary>
  /// Language.
  /// </summary>
  [XmlEnum("language")]
  Language,
  
  /// <summary>
  /// ID.
  /// </summary>
  [XmlEnum("ID")]
  Id,
  
  /// <summary>
  /// IDREF.
  /// </summary>
  [XmlEnum("IDREF")]
  IdRef,
  
  /// <summary>
  /// IDREFS.
  /// </summary>
  [XmlEnum("IDREFS")]
  IdRefs,
  
  /// <summary>
  /// ENTITY.
  /// </summary>
  [XmlEnum("ENTITY")]
  Entity,
  
  /// <summary>
  /// ENTITIES.
  /// </summary>
  [XmlEnum("ENTITIES")]
  Entities,
  
  /// <summary>
  /// Notation.
  /// </summary>
  [XmlEnum("NOTATION")]
  Notation,
  
  /// <summary>
  /// NMTOKEN.
  /// </summary>
  [XmlEnum("NMTOKEN")]
  NMToken,
  
  /// <summary>
  /// NMTOKENS.
  /// </summary>
  [XmlEnum("NMTOKENS")]
  NMTokens,
  
  /// <summary>
  /// Any Type.
  /// </summary>
  [XmlEnum("anyType")]
  AnyType,
  
}
