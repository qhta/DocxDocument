namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public class NumberingImpl: ModelElementImpl, Numbering
{
  public DocumentFormat.OpenXml.Wordprocessing.Numbering? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Numbering?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingImpl(): base() {}
  
  public NumberingImpl(DocumentFormat.OpenXml.Wordprocessing.Numbering openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.NumberingPictureBullet>? NumberingPictureBullets
  {
    get
    {
      if (_NumberingPictureBullets != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>()
            .Select(item => new DocumentModel.Wordprocessing.NumberingPictureBulletImpl(item)).ToList();
          _NumberingPictureBullets = new ObservableCollection<DocumentModel.Wordprocessing.NumberingPictureBullet>(items);
        }
        else
          _NumberingPictureBullets = new ObservableCollection<DocumentModel.Wordprocessing.NumberingPictureBullet>();
        _NumberingPictureBullets.CollectionChanged += _NumberingPictureBullets_CollectionChanged;
      }
      return _NumberingPictureBullets;
    }
    set
    {
      if (value != null && value != _NumberingPictureBullets && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.NumberingPictureBulletImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.NumberingPictureBullet> observableCollection)
        _NumberingPictureBullets = observableCollection;
      else if (value != null)
        _NumberingPictureBullets = new ObservableCollection<DocumentModel.Wordprocessing.NumberingPictureBullet>(value);
      else
       _NumberingPictureBullets = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.NumberingPictureBullet>? _NumberingPictureBullets;
  
  private void _NumberingPictureBullets_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.NumberingPictureBulletImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.NumberingPictureBulletImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>()
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
  
  
  public Collection<DocumentModel.Wordprocessing.AbstractNum>? AbstractNums
  {
    get
    {
      if (_AbstractNums != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>()
            .Select(item => new DocumentModel.Wordprocessing.AbstractNumImpl(item)).ToList();
          _AbstractNums = new ObservableCollection<DocumentModel.Wordprocessing.AbstractNum>(items);
        }
        else
          _AbstractNums = new ObservableCollection<DocumentModel.Wordprocessing.AbstractNum>();
        _AbstractNums.CollectionChanged += _AbstractNums_CollectionChanged;
      }
      return _AbstractNums;
    }
    set
    {
      if (value != null && value != _AbstractNums && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.AbstractNumImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.AbstractNum> observableCollection)
        _AbstractNums = observableCollection;
      else if (value != null)
        _AbstractNums = new ObservableCollection<DocumentModel.Wordprocessing.AbstractNum>(value);
      else
       _AbstractNums = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.AbstractNum>? _AbstractNums;
  
  private void _AbstractNums_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.AbstractNumImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.AbstractNumImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>()
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
  
  
  public Collection<DocumentModel.Wordprocessing.NumberingInstance>? NumberingInstances
  {
    get
    {
      if (_NumberingInstances != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>()
            .Select(item => new DocumentModel.Wordprocessing.NumberingInstanceImpl(item)).ToList();
          _NumberingInstances = new ObservableCollection<DocumentModel.Wordprocessing.NumberingInstance>(items);
        }
        else
          _NumberingInstances = new ObservableCollection<DocumentModel.Wordprocessing.NumberingInstance>();
        _NumberingInstances.CollectionChanged += _NumberingInstances_CollectionChanged;
      }
      return _NumberingInstances;
    }
    set
    {
      if (value != null && value != _NumberingInstances && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.NumberingInstanceImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.NumberingInstance> observableCollection)
        _NumberingInstances = observableCollection;
      else if (value != null)
        _NumberingInstances = new ObservableCollection<DocumentModel.Wordprocessing.NumberingInstance>(value);
      else
       _NumberingInstances = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.NumberingInstance>? _NumberingInstances;
  
  private void _NumberingInstances_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.NumberingInstanceImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.NumberingInstanceImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>()
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
  
  
  public Int32? NumberingIdMacAtCleanup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
