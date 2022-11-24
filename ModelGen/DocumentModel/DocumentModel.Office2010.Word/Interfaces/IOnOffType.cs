namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the OnOffType Class.
/// </summary>
public interface IOnOffType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffValues? Val { get ; set; }
  
}
