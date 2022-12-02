namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SparklineGroups Class.
/// </summary>
public interface ISparklineGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ISparklineGroup>? SparklineGroups { get ; set; }
  
}
