namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public class DelimiterImpl: ModelElementImpl, Delimiter
{
  public DocumentFormat.OpenXml.Math.Delimiter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Delimiter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DelimiterImpl(): base() {}
  
  public DelimiterImpl(DocumentFormat.OpenXml.Math.Delimiter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DocumentModel.Math.DelimiterProperties? DelimiterProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
        if (item != null)
          return new DocumentModel.Math.DelimiterPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.DelimiterPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Math.Base>? Bases
  {
    get
    {
      if (_Bases != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>()
            .Select(item => new DocumentModel.Math.BaseImpl(item)).ToList();
          _Bases = new ObservableCollection<DocumentModel.Math.Base>(items);
        }
        else
          _Bases = new ObservableCollection<DocumentModel.Math.Base>();
        _Bases.CollectionChanged += _Bases_CollectionChanged;
      }
      return _Bases;
    }
    set
    {
      if (value != null && value != _Bases && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Math.BaseImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Math.Base> observableCollection)
        _Bases = observableCollection;
      else if (value != null)
        _Bases = new ObservableCollection<DocumentModel.Math.Base>(value);
      else
       _Bases = null;
    }
  }
  private ObservableCollection<DocumentModel.Math.Base>? _Bases;
  
  private void _Bases_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Math.BaseImpl valImpl)
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
              if (val is DocumentModel.Math.BaseImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>()
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
