namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SparklineGroups Class.
/// </summary>
public interface ISparklineGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ISparklineGroup>? SparklineGroups { get ; set; }
  
}
