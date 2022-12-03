namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtension Class.
/// </summary>
public interface CalculatedMemberExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public CalculatedMember? CalculatedMember { get ; set; }
  
}
