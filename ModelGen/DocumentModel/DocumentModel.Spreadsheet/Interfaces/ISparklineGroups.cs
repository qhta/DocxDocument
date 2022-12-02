namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SparklineGroups Class.
/// </summary>
public interface ISparklineGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISparklineGroup>? SparklineGroups { get ; set; }
  
}
