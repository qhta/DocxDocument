namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public interface OpenXmlFormulaElement
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.FormulaDirection? Dir { get ; set; }
  
}
