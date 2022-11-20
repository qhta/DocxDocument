namespace DocumentModel.Spreadsheet;

/// <summary>
/// Color Scale.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormatValueObject))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class ColorScale: IColorScale
{
}
