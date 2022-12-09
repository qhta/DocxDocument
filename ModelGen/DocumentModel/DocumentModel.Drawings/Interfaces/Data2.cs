namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public interface Data2
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public Collection<NumericDimension>? NumericDimensions { get ; set; }
  
  public Collection<StringDimension>? StringDimensions { get ; set; }
  
  public ExtensionList2? ExtensionList { get ; set; }
  
}
