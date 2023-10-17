namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Layout.
/// </summary>
public partial class Layout
{
  
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.ManualLayout? ManualLayout { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
