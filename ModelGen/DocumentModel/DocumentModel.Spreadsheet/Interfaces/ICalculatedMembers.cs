namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMembers Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICalculatedMember))]
public interface ICalculatedMembers // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Calculated Members Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
