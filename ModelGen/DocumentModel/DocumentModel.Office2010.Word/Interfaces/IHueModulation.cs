namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the HueModulation Class.
/// </summary>
public interface IHueModulation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Val { get ; set; }
  
}
