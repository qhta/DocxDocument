namespace DocumentModel.Drawings.Charts;

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
  
  public ContentPartImpl(): base() {}
  
  public ContentPartImpl(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId
  {
    get => (System.String?)OpenXmlElement?.RelationshipId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelationshipId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BlackWhiteMode
  {
    get => (DocumentModel.Drawings.BlackWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualContentPartProperties? NonVisualContentPartProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawings.Charts.Transform2D? Transform2D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
