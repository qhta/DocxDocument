namespace DocumentModel.Office2019.Drawing;

/// <summary>
/// Defines the Decorative Class.
/// </summary>
public interface IDecorative // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2019 and later.
  /// </summary>
  public Boolean? Val { get ; set; }
  
}
