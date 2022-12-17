namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public class CustomColorListImpl: ModelElementImpl, CustomColorList
{
  public DocumentFormat.OpenXml.Drawing.CustomColorList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CustomColorList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomColorListImpl(): base() {}
  
  public CustomColorListImpl(DocumentFormat.OpenXml.Drawing.CustomColorList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.CustomColor>? CustomColors
  {
    get
    {
      if (_CustomColors != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.CustomColor>()
            .Select(item => new DocumentModel.Drawings.CustomColorImpl(item)).ToList();
          _CustomColors = new ObservableCollection<DocumentModel.Drawings.CustomColor>(items);
        }
        else
          _CustomColors = new ObservableCollection<DocumentModel.Drawings.CustomColor>();
        _CustomColors.CollectionChanged += _CustomColors_CollectionChanged;
      }
      return _CustomColors;
    }
    set
    {
      if (value != null && value != _CustomColors && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.CustomColor>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.CustomColorImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.CustomColor> observableCollection)
        _CustomColors = observableCollection;
      else if (value != null)
        _CustomColors = new ObservableCollection<DocumentModel.Drawings.CustomColor>(value);
      else
       _CustomColors = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.CustomColor>? _CustomColors;
  
  private void _CustomColors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.CustomColor>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.CustomColorImpl valImpl)
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
              if (val is DocumentModel.Drawings.CustomColorImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.CustomColor>()
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
