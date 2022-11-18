namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldsUsage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldUsage))]
public interface IFieldsUsage // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
