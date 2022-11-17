namespace DocumentModel.VariantTypes;

public enum ArrayBase
{

  [XmlEnum("variant")]
  Variant,

  [XmlEnum("i1")]
  OneByteSignedInteger,

  [XmlEnum("i2")]
  TwoBytesSignedInteger,

  [XmlEnum("i4")]
  FourBytesSignedInteger,

  [XmlEnum("int")]
  Integer,

  [XmlEnum("ui1")]
  OneByteUnsignedInteger,

  [XmlEnum("ui2")]
  TwoBytesUnsignedInteger,

  [XmlEnum("ui4")]
  FourBytesUnsignedInteger,

  [XmlEnum("uint")]
  UnsignedInteger,

  [XmlEnum("r4")]
  FourBytesReal,

  [XmlEnum("r8")]
  EightBytesReal,

  [XmlEnum("decimal")]
  Decimal,

  [XmlEnum("bstr")]
  Bstr,

  [XmlEnum("date")]
  Date,

  [XmlEnum("bool")]
  Bool,

  [XmlEnum("cy")]
  Currency,

  [XmlEnum("error")]
  Error,
}
