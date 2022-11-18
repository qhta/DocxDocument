namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the GroupLevels Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupLevel))]
public interface IGroupLevels // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping Level Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
