namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public class PrintSettingsImpl: ModelElementImpl, PrintSettings
{
  public DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PrintSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PrintSettingsImpl(): base() {}
  
  public PrintSettingsImpl(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public DocumentModel.Drawings.Charts.HeaderFooter? HeaderFooter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.HeaderFooterImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.HeaderFooterImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public DocumentModel.Drawings.Charts.PageMargins? PageMargins
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PageMarginsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PageMarginsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public DocumentModel.Drawings.Charts.PageSetup? PageSetup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PageSetupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PageSetupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public DocumentModel.Drawings.Charts.RelationshipIdType? LegacyDrawingHeaderFooter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.RelationshipIdTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.RelationshipIdTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
