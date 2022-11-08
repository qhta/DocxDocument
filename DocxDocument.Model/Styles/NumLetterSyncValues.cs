namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum NumLetterSync
{
  /// <summary>
  /// A new digit is inserted that always has the same value as the following digit. 
  /// The numbering sequence (for lower case numberings) in that case is 
  /// a, b, c, ..., z, aa, bb, cc, ..., zz, aaa, ..., and so on.
  /// </summary>
  Paired,

  /// <summary>
  /// A new digit is inserted. Its start value is ”a” or ”A”, 
  /// and it is incremented every time an overflow occurs in the following digit. 
  /// The numbering sequence (for lower case numberings) in that case is 
  /// a,b,c, ..., z, aa, ab, ac, ...,az, ba, ..., and so on.
  /// </summary>
  Consecutive, 
}