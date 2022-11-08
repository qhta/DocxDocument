namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum VariantType
{
  /// <summary> 
  /// This element specifies an empty variant type. 
  /// No values or child elements are allowed.
  ///</summary> 
  Empty,

  /// <summary> 
  /// This element specifies a null variant type.
  ///</summary> 
  Null,

  /// <summary> 
  /// This element specifies a Boolean variant type.
  ///</summary> 
  Bool,

  /// <summary> 
  /// This element specifies a 1-byte signed integer variant type.
  ///</summary> 
  Int8,

  /// <summary> 
  /// This element specifies a 2-byte signed integer variant type.
  ///</summary> 
  Int16,

  /// <summary> 
  /// This element specifies a 4-byte signed integer variant type.
  ///</summary> 
  Int32,

  /// <summary> 
  /// This element specifies a 8-byte signed integer variant type.
  ///</summary> 
  Int64,

  /// <summary> 
  /// This element specifies a 1-byte unsigned integer variant type.
  ///</summary> 
  UInt8,

  /// <summary> 
  /// This element specifies a 2-byte unsigned integer variant type.
  ///</summary> 
  UInt16,

  /// <summary> 
  /// This element specifies a 4-byte unsigned integer variant type.
  ///</summary> 
  UInt32,

  /// <summary> 
  /// This element specifies a 8-byte unsigned integer variant type.
  ///</summary> 
  UInt64,

  /// <summary> 
  /// This element specifies a 4-byte real number variant type.
  ///</summary> 
  Float,

  /// <summary> 
  /// This element specifies a 8-byte real number variant type.
  ///</summary> 
  Double,

  /// <summary> 
  /// This element specifies a decimal variant type.
  ///</summary> 
  Decimal,

  /// <summary> 
  /// This element specifies a currency variant type with exactly four digits after the decimal point.
  ///</summary> 
  Currency,

  /// <summary> 
  /// This element specifies a file-time variant type of type date-time as defined in RFC 3339.
  ///</summary> 
  DateTime,

  /// <summary> 
  /// This element specifies a date variant type of type date-time as defined in RFC 3339.
  /// Only date is important.
  ///</summary> 
  Date,


  /// <summary> 
  /// This element specifies a string variant type. 
  /// For all characters that cannot be represented in XML as defined by the XML 1.0 specification, 
  /// the characters are escaped using the Unicode numerical character representation escape character format _xHHHH_, 
  /// where H represents a hexadecimal character in the character's value. 
  /// [Example: The Unicode character 8 is not permitted in an XML 1.0 document, so it must be escaped as _x0008_. end example]
  ///</summary> 
  String,

  /// <summary> 
  /// This element specifies a base64 binary blob variant type. 
  /// This type is defined as follows: a DWORD count of bytes, followed by that many bytes of data. 
  /// The byte count does not include the four bytes for the length of the count itself; an empty blob member would have a count of zero, followed by zero bytes.
  ///</summary> 
  Blob,

  /// <summary> 
  /// This element specifies a base64 binary blob object variant type. This type is defined as follows:
  /// A blob member that contains a serialized object in the same representation that would appear in the ostream element.
  /// That is, a DWORD byte count (where the byte count does not include the size of itself)
  /// which is in the format of a class identifier followed by initialization data for that class
  ///</summary> 
  OBlob,

  /// <summary> 
  /// This element specifies a binary storage variant type. This type is defined as follows: 
  /// Contains the base64-encoded data for a structured storage.
  ///</summary> 
  Storage,

  /// <summary> 
  /// This element specifies a base64 binary storage object variant type. This type is defined as follows:
  /// Identical to the storage element, but indicates that the designated storage shall contain a loadable object.
  ///</summary> 
  OStorage,

  /// <summary> 
  /// This element specifies a binary stream variant type. This type is defined as follows: 
  /// Contains the base64-encoded data for a structured storage stream.
  ///</summary> 
  StreamData,

  /// <summary> 
  /// This element specifies a binary stream object variant type. This type is defined as follows:
  /// Identical to the definition of the stream element, but indicates that the stream contains a serialized object,
  /// which is a CLSID followed by initialization data for the specified class.
  ///</summary> 
  OStreamData,

  /// <summary> 
  /// This element specifies a binary versioned stream variant type. This type is defined as follows: 
  /// A stream element's content with a GUID version (the version attribute).
  ///</summary> 
  VStreamData,

  /// <summary> 
  /// This element specifies a class ID variant type. 
  /// The value shall be a Globally Unique Identifier with format: {HHHHHHHH-HHHH-HHHH-HHHH-HHHHHHHH}.
  ///</summary> 
  ClassId,

  /// <summary> 
  /// The error element specifies a 32-bit error status code variant type of the form 0xHHHHHHHH. 
  /// Each H represents a hexadecimal digit.
  ///</summary> 
  Error,

  /// <summary> 
  /// This element contains ClipboardData in some specific format.
  ///</summary> 
  ClipboardData,

  /// <summary> 
  /// This element can contain exactly 1 child element of any variant type. 
  /// This element is only valid as a child element of a vector or array variant type.
  ///</summary> 
  Variant = 0x0FFF,

  /// <summary> 
  /// The array element defines the array variant type. 
  /// Array contents shall be of uniform type as specified by the baseType attribute. 
  /// The contents of an array are defined using repeated child elements of the appropriate variant type. 
  /// Multi-dimensional arrays can be defined by specifying the length of each dimension 
  /// in the lBound and uBound attributes through the use of the , delimiter. 
  /// Child elements of multi-dimensional arrays are indexed along each dimension in the order the dimensions are declared.
  ///</summary> 
  Array = 0x2000,

  /// <summary> 
  /// This element defines the vector variant type. 
  /// Vector contents shall be of uniform type as specified by the baseType attribute. 
  /// The contents of a vector are defined using repeated child elements of the appropriate variant type.
  ///</summary> 
  Vector = 0x4000,

};
