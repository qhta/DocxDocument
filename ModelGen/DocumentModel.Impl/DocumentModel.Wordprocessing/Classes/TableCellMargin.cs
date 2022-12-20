namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public partial class TableCellMarginImpl: ModelElementImpl, TableCellMargin
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableCellMargin?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TableCellMarginImpl(): base() {}
  
  public TableCellMarginImpl(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TopMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Cell Left Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? LeftMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? StartMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? BottomMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Cell Right Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? RightMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? EndMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
