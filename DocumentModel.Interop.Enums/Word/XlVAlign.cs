namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlVAlign")]
public enum VAlign
{
  /// <summary>
  /// Top
  /// </summary>
  [WordInteropEnumValue("xlVAlignTop")]
  Top = -4160,
  /// <summary>
  /// Justify
  /// </summary>
  [WordInteropEnumValue("xlVAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Distributed
  /// </summary>
  [WordInteropEnumValue("xlVAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Center
  /// </summary>
  [WordInteropEnumValue("xlVAlignCenter")]
  Center = -4108,
  /// <summary>
  /// Bottom
  /// </summary>
  [WordInteropEnumValue("xlVAlignBottom")]
  Bottom = -4107
}
