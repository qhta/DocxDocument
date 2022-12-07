namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public class NumRefExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>, NumRefExtension
{
  public FullReference? FullReference
  {
    get;
    set;
  }
  
  public LevelReference? LevelReference
  {
    get;
    set;
  }
  
  public FormulaReference? FormulaReference
  {
    get;
    set;
  }
  
}
