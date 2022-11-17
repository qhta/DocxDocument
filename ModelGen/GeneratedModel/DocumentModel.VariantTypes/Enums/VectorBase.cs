namespace DocumentModel.VariantTypes;

public enum VectorBase
{

  [XmlEnum("variant")]
  Variant,

  [XmlEnum("i1")]
  OneByteSignedInteger,

  [XmlEnum("i2")]
  TwoBytesSignedInteger,

  [XmlEnum("i4")]
  FourBytesSignedInteger,

  [XmlEnum("i8")]
  EightBytesSignedInteger,

  [XmlEnum("ui1")]
  OneByteUnsignedInteger,

  [XmlEnum("ui2")]
  TwoBytesUnsignedInteger,

  [XmlEnum("ui4")]
  FourBytesUnsignedInteger,

  [XmlEnum("ui8")]
  EightBytesUnsignedInteger,

  [XmlEnum("r4")]
  FourBytesReal,

  [XmlEnum("r8")]
  EightBytesReal,

  [XmlEnum("lpstr")]
  Lpstr,

  [XmlEnum("lpwstr")]
  Lpwstr,

  [XmlEnum("bstr")]
  Bstr,

  [XmlEnum("date")]
  Date,

  [XmlEnum("filetime")]
  Filetime,

  [XmlEnum("bool")]
  Bool,

  [XmlEnum("cy")]
  Currency,

  [XmlEnum("error")]
  Error,

  [XmlEnum("clsid")]
  ClassId,

  [XmlEnum("cf")]
  ClipboardData,
}
