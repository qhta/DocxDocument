namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public interface NumberingCache // : DocumentModel.Drawings.NumberDataType
{
  public String? FormatCode { get ; set; }
  
  public UInt32? PointCount { get ; set; }
  
  public Collection<NumericPoint>? NumericPoints { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
