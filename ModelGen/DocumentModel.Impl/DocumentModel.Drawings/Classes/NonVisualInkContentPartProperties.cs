namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public class NonVisualInkContentPartPropertiesImpl: ModelElementImpl, NonVisualInkContentPartProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public ContentPartLocks? ContentPartLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList6? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
