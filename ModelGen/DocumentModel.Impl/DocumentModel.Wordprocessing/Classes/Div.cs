namespace DocumentModel.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
public class DivImpl: ModelElementImpl, Div
{
  public DocumentFormat.OpenXml.Wordprocessing.Div? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Div?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DivImpl(): base() {}
  
  public DivImpl(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// div Data ID
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  public Boolean? BlockQuote
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BlockQuote>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BlockQuote>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BlockQuote();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  public Boolean? BodyDiv
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BodyDiv>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BodyDiv>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BodyDiv();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  public String? LeftMarginDiv
  {
    get => (System.String?)OpenXmlElement?.LeftMarginDiv?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LeftMarginDiv != null)
        {
          if (value is not null)
            OpenXmlElement.LeftMarginDiv.Val = (System.String?)value;
          else
            OpenXmlElement.LeftMarginDiv = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LeftMarginDiv = new DocumentFormat.OpenXml.Wordprocessing.LeftMarginDiv{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  public String? RightMarginDiv
  {
    get => (System.String?)OpenXmlElement?.RightMarginDiv?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RightMarginDiv != null)
        {
          if (value is not null)
            OpenXmlElement.RightMarginDiv.Val = (System.String?)value;
          else
            OpenXmlElement.RightMarginDiv = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RightMarginDiv = new DocumentFormat.OpenXml.Wordprocessing.RightMarginDiv{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  public String? TopMarginDiv
  {
    get => (System.String?)OpenXmlElement?.TopMarginDiv?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TopMarginDiv != null)
        {
          if (value is not null)
            OpenXmlElement.TopMarginDiv.Val = (System.String?)value;
          else
            OpenXmlElement.TopMarginDiv = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TopMarginDiv = new DocumentFormat.OpenXml.Wordprocessing.TopMarginDiv{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  public String? BottomMarginDiv
  {
    get => (System.String?)OpenXmlElement?.BottomMarginDiv?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BottomMarginDiv != null)
        {
          if (value is not null)
            OpenXmlElement.BottomMarginDiv.Val = (System.String?)value;
          else
            OpenXmlElement.BottomMarginDiv = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BottomMarginDiv = new DocumentFormat.OpenXml.Wordprocessing.BottomMarginDiv{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.DivBorder? DivBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivBorder>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DivBorderImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivBorder>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DivBorderImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.DivsChild>? DivsChilds
  {
    get
    {
      if (_DivsChilds != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DivsChild>()
            .Select(item => new DocumentModel.Wordprocessing.DivsChildImpl(item)).ToList();
          _DivsChilds = new ObservableCollection<DocumentModel.Wordprocessing.DivsChild>(items);
        }
        else
          _DivsChilds = new ObservableCollection<DocumentModel.Wordprocessing.DivsChild>();
        _DivsChilds.CollectionChanged += _DivsChilds_CollectionChanged;
      }
      return _DivsChilds;
    }
    set
    {
      if (value != null && value != _DivsChilds && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DivsChild>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.DivsChildImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.DivsChild> observableCollection)
        _DivsChilds = observableCollection;
      else if (value != null)
        _DivsChilds = new ObservableCollection<DocumentModel.Wordprocessing.DivsChild>(value);
      else
       _DivsChilds = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.DivsChild>? _DivsChilds;
  
  private void _DivsChilds_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DivsChild>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.DivsChildImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Wordprocessing.DivsChildImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DivsChild>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    oldItem.Remove();
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
