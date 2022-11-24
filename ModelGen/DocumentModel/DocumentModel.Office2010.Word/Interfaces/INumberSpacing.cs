namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the NumberSpacing Class.
/// </summary>
public interface INumberSpacing // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public NumberSpacingValues? Val { get ; set; }
  
}
