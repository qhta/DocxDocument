namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public interface TextData
{
  public OpenXmlFormulaElement? Formula { get ; set; }
  
  public String? VXsdstring { get ; set; }
  
}
