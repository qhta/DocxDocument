namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Layout.
/// </summary>
public partial class Layout
{
  
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  public DMDC.ManualLayout? ManualLayout { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
