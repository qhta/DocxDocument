namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public class AdjustValueListImpl: ModelElementImpl, AdjustValueList
{
  public DocumentFormat.OpenXml.Drawing.AdjustValueList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustValueList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AdjustValueListImpl(): base() {}
  
  public AdjustValueListImpl(DocumentFormat.OpenXml.Drawing.AdjustValueList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ShapeGuide>? ShapeGuides
  {
    get
    {
      if (_ShapeGuides != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapeGuide>()
            .Select(item => new DocumentModel.Drawings.ShapeGuideImpl(item)).ToList();
          _ShapeGuides = new ObservableCollection<DocumentModel.Drawings.ShapeGuide>(items);
        }
        else
          _ShapeGuides = new ObservableCollection<DocumentModel.Drawings.ShapeGuide>();
        _ShapeGuides.CollectionChanged += _ShapeGuides_CollectionChanged;
      }
      return _ShapeGuides;
    }
    set
    {
      if (value != null && value != _ShapeGuides && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapeGuide>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings.ShapeGuideImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ShapeGuide> observableCollection)
        _ShapeGuides = observableCollection;
      else if (value != null)
        _ShapeGuides = new ObservableCollection<DocumentModel.Drawings.ShapeGuide>(value);
      else
       _ShapeGuides = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ShapeGuide>? _ShapeGuides;
  
  private void _ShapeGuides_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapeGuide>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings.ShapeGuideImpl valImpl)
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
              if (val is DocumentModel.Drawings.ShapeGuideImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapeGuide>()
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
