namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TextFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITextField))]
public interface ITextFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Count of Fields
  /// </summary>
  public uint? Count { get ; set; }
  
}
