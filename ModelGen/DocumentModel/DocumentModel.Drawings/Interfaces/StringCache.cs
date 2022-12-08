namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public interface StringCache
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<StringPoint>? StringPoints { get ; set; }
  
  public StrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
