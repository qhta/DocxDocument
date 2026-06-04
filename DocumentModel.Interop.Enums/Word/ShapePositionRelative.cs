namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the LeftRelative or TopRelative property for a Shape or ShapeRange is valid.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapepositionrelative?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdShapePositionRelative))]
public enum ShapePositionRelative
{
  /// <summary>
  /// Specifies whether the LeftRelative or TopRelative property for a Shape or ShapeRange is valid.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePositionRelative.wdShapePositionRelativeNone))]
  None = -999999
}
