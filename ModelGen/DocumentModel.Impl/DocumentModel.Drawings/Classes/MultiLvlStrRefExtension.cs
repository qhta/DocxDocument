namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public class MultiLvlStrRefExtensionImpl: ModelElementImpl, MultiLvlStrRefExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
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
