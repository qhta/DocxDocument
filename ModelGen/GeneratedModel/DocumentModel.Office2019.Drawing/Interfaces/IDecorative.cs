namespace DocumentModel.Office2019.Drawing;

/// <summary>
/// Defines the Decorative Class.
/// </summary>
public interface IDecorative // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Val { get ; set; }
  
}
