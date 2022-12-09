namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public interface NumberingCache
{
  public String? FormatCode { get ; set; }
  
  public UInt32? PointCount { get ; set; }
  
  public Collection<NumericPoint>? NumericPoints { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
