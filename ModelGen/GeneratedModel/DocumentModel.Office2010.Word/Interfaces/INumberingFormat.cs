namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public NumberForm? Val { get ; set; }
  
}
