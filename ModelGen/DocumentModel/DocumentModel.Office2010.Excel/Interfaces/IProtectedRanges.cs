namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ProtectedRanges Class.
/// </summary>
public interface IProtectedRanges // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IProtectedRange>? ProtectedRanges { get ; set; }
  
}
