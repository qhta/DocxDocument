namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettingsImpl: ModelElementImpl, PrintSettings
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PrintSettingsImpl(): base() {}
  
  public PrintSettingsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.HeaderFooter? HeaderFooter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.HeaderFooterImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.HeaderFooterImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PageMargins? PageMargins
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.PageMarginsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.PageMarginsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PageSetup? PageSetup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.PageSetupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.PageSetupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
