namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface ChartData // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public ExternalData? ExternalData { get ; set; }
  
  public Collection<Data>? Datas { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
