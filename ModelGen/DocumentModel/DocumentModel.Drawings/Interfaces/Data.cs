namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public interface Data
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public NumericDimension? NumericDimension { get ; set; }
  
  public StringDimension? StringDimension { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
