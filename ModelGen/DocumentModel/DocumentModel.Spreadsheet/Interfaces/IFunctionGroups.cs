namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FunctionGroups Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFunctionGroup))]
public interface IFunctionGroups // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Built-in Function Group Count
  /// </summary>
  public uint? BuiltInGroupCount { get ; set; }
  
}
