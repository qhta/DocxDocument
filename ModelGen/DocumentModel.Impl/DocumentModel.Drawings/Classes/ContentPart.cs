namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public class ContentPartImpl: ModelElementImpl, ContentPart
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId
  {
    get;
    set;
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode
  {
    get => (BlackWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public NonVisualContentPartProperties? NonVisualContentPartProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D1? Transform2D
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList7? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
