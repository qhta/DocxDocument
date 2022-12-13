namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public interface StringDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.StringDimensionType? Type { get ; set; }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? Formula { get ; set; }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? NfFormula { get ; set; }
  
  public Collection<DocumentModel.Drawings16.Charts.StringLevel>? StringLevels { get ; set; }
  
  public DocumentModel.Drawings16.Charts.StringLevel? StringLevel { get ; set; }
  
}
