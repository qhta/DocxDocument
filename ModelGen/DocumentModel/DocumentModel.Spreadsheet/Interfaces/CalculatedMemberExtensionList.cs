namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtensionList Class.
/// </summary>
public interface CalculatedMemberExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<CalculatedMemberExtension>? CalculatedMemberExtensions { get ; set; }
  
}
