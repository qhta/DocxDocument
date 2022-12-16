namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public class PictureImpl: ModelElementImpl, Picture
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PictureImpl(): base() {}
  
  public PictureImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro
  {
    get => (System.String?)OpenXmlElement?.Macro?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Macro = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published
  {
    get => (System.Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties? NonVisualPictureProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualPicturePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualPicturePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.BlipFill? BlipFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.BlipFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.BlipFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Style.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Style? Style
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.StyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.StyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
