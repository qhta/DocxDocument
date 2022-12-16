namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public class BubbleSerExtensionImpl: ModelElementImpl, BubbleSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BubbleSerExtensionImpl(): base() {}
  
  public BubbleSerExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.InvertSolidFillFormat? InvertSolidFillFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.InvertSolidFillFormatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.InvertSolidFillFormatImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredCategoryTitle? FilteredCategoryTitle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredCategoryTitleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredCategoryTitleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.DataLabelsRange? DataLabelsRange
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DataLabelsRangeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DataLabelsRangeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.CategoryFilterExceptions? CategoryFilterExceptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.CategoryFilterExceptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.CategoryFilterExceptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
