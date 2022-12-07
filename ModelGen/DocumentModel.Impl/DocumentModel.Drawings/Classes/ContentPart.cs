namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public class ContentPartImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart>, ContentPart
{
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
  public Transform2D3? Transform2D
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList4? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
