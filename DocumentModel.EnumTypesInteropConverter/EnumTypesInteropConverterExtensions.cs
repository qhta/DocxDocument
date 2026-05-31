using Qhta.Collections;

namespace DocumentModel.EnumTypesInteropConverter;

using Word = Microsoft.Office.Interop.Word;

/// <summary>
/// Converter extensions for enum types between DocumentModel and Microsoft.Office.Interop.Word namespaces.
/// </summary>
public static class EnumTypesInteropConverterExtensions
{
  /// <summary>
  /// Converts a Word line style enumeration to the corresponding DocumentModel line style enumeration.
  /// <remarks>
  /// It is a one-to-one mapping based on the integer values of the enumeration members, assuming they are defined in the same order in both enums.
  /// </remarks>
  /// </summary>
  /// <param name="lineStyle">The Word line style to convert.</param>
  /// <returns>The corresponding DocumentModel line style.</returns>
  public static DocumentModel.Wordprocessing.LineStyle ToLineType(this Word.WdLineStyle lineStyle)
  {
    return (Wordprocessing.LineStyle)((int)lineStyle);
  }

  /// <summary>
  /// Converts a DocumentModel LineStyle enumeration value to the corresponding Word WdLineStyle enumeration value.
  /// <remarks>
  /// It is a one-to-one mapping based on the integer values of the enumeration members, assuming they are defined in the same order in both enums.
  /// </remarks>
  /// </summary>
  /// <param name="lineStyle">The LineStyle value to convert.</param>
  /// <returns>The corresponding WdLineStyle enumeration value.</returns>
  public static Word.WdLineStyle ToWdLineStyle(this DocumentModel.Wordprocessing.LineStyle lineStyle)
  {
    return (Word.WdLineStyle)((int)lineStyle);
  }
}
