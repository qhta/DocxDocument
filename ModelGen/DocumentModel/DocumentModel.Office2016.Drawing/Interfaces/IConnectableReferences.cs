namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the ConnectableReferences Class.
/// </summary>
public interface IConnectableReferences // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// st, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? St { get ; set; }
  
  /// <summary>
  /// end, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? End { get ; set; }
  
}
