namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ToolbarData Class.
/// </summary>
public class ToolbarDataImpl: ModelElementImpl, ToolbarData
{
  public DocumentFormat.OpenXml.Office.Word.ToolbarData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.ToolbarData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
