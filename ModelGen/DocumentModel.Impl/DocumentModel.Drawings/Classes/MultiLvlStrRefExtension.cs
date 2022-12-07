namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public class MultiLvlStrRefExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>, MultiLvlStrRefExtension
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
