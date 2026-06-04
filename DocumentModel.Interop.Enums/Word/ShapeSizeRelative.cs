namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the WidthRelative or HeightRelative property for a Shape or ShapeRange object is valid.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapesizerelative?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdShapeSizeRelative")]
public enum ShapeSizeRelative
{
  /// <summary>
  /// Specifies whether the WidthRelative or HeightRelative property for a Shape or ShapeRange object is valid.
  /// </summary>
  [WordInteropEnumValue("wdShapeSizeRelativeNone")]
  None = -999999
}
