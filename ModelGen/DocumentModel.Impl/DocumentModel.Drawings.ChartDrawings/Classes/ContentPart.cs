namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public partial class ContentPartImpl: ModelElementImpl, ContentPart
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
  public DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? NonVisualContentPartProperties
  {
    get
    {
      if (OpenXmlElement?.NonVisualContentPartProperties != null)
        return new DocumentModel.Drawings.ChartDrawings.NonVisualContentPartPropertiesImpl(OpenXmlElement.NonVisualContentPartProperties);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ChartDrawings.NonVisualContentPartPropertiesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.NonVisualContentPartProperties = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement?.ApplicationNonVisualDrawingProperties != null)
        return new DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingPropertiesImpl(OpenXmlElement.ApplicationNonVisualDrawingProperties);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingPropertiesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ApplicationNonVisualDrawingProperties = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Transform2D? Transform2D
  {
    get
    {
      if (OpenXmlElement?.Transform2D != null)
        return new DocumentModel.Drawings.ChartDrawings.Transform2DImpl(OpenXmlElement.Transform2D);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ChartDrawings.Transform2DImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Transform2D = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement?.OfficeArtExtensionList != null)
        return new DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionListImpl(OpenXmlElement.OfficeArtExtensionList);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionListImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.OfficeArtExtensionList = valueImpl.OpenXmlElement;
    }
  }
  
}
