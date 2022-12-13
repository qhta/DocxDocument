namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public interface NumericDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.NumericDimensionType? Type { get ; set; }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? Formula { get ; set; }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? NfFormula { get ; set; }
  
  public Collection<DocumentModel.Drawings16.Charts.NumericLevel>? NumericLevels { get ; set; }
  
  public DocumentModel.Drawings16.Charts.NumericLevel? NumericLevel { get ; set; }
  
}
