namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlVAlign")]
public enum VAlign
{
  /// <summary>
  /// Top
  /// </summary>
  [InteropEnumValue("xlVAlignTop")]
  Top = -4160,
  /// <summary>
  /// Justify
  /// </summary>
  [InteropEnumValue("xlVAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Distributed
  /// </summary>
  [InteropEnumValue("xlVAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Center
  /// </summary>
  [InteropEnumValue("xlVAlignCenter")]
  Center = -4108,
  /// <summary>
  /// Bottom
  /// </summary>
  [InteropEnumValue("xlVAlignBottom")]
  Bottom = -4107
}

