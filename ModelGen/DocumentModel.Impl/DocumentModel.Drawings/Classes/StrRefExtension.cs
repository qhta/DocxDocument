namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public class StrRefExtensionImpl: ModelElementImpl, StrRefExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension?)_OpenXmlElement;
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
