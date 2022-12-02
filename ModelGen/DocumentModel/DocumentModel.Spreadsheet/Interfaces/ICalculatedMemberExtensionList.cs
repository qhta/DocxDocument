namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtensionList Class.
/// </summary>
public interface ICalculatedMemberExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICalculatedMemberExtension>? CalculatedMemberExtensions { get ; set; }
  
}
