namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public interface TextData // : DocumentModel.BaseTypes.ModelElement
{
  public OpenXmlFormulaElement? Formula { get ; set; }
  
  public String? VXsdstring { get ; set; }
  
}
