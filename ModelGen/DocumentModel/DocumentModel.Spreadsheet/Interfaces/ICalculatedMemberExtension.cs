namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtension Class.
/// </summary>
public interface ICalculatedMemberExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ICalculatedMember? CalculatedMember { get ; set; }
  
}
