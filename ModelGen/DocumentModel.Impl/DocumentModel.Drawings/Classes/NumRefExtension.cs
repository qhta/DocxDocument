namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public class NumRefExtensionImpl: ModelElementImpl, NumRefExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension?)_OpenXmlElement;
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
