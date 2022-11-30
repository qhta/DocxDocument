namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtensionList Class.
/// </summary>
public interface ICalculatedMemberExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICalculatedMemberExtension>? CalculatedMemberExtensions { get ; set; }
  
}
