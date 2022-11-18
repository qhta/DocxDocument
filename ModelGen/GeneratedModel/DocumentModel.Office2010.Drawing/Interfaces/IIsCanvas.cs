namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the IsCanvas Class.
/// </summary>
public interface IIsCanvas // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Val { get ; set; }
  
}
