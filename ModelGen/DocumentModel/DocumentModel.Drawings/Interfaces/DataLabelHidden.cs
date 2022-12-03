namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public interface DataLabelHidden // : System.Boolean
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get ; set; }
  
}
