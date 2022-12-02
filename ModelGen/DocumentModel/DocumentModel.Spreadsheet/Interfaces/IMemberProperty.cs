namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Property.
/// </summary>
public interface IMemberProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// OLAP Member Property Unique Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Show Cell
  /// </summary>
  public Boolean? ShowCell { get ; set; }
  
  /// <summary>
  /// Show Tooltip
  /// </summary>
  public Boolean? ShowTip { get ; set; }
  
  /// <summary>
  /// Show As Caption
  /// </summary>
  public Boolean? ShowAsCaption { get ; set; }
  
  /// <summary>
  /// Name Length
  /// </summary>
  public UInt32? NameLength { get ; set; }
  
  /// <summary>
  /// Property Name Character Index
  /// </summary>
  public UInt32? PropertyNamePosition { get ; set; }
  
  /// <summary>
  /// Property Name Length
  /// </summary>
  public UInt32? PropertyNameLength { get ; set; }
  
  /// <summary>
  /// Level Index
  /// </summary>
  public UInt32? Level { get ; set; }
  
  /// <summary>
  /// Field Index
  /// </summary>
  public UInt32? Field { get ; set; }
  
}
