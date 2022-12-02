namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtension Class.
/// </summary>
public interface ICalculatedMemberExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.ICalculatedMember? CalculatedMember { get ; set; }
  
}
