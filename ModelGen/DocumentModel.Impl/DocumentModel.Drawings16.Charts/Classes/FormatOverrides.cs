namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public class FormatOverridesImpl: ModelElementImpl, FormatOverrides
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FormatOverridesImpl(): base() {}
  
  public FormatOverridesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings16.Charts.FormatOverride>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>()
            .Select(item => new DocumentModel.Drawings16.Charts.FormatOverrideImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.FormatOverride>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.FormatOverride>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings16.Charts.FormatOverrideImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings16.Charts.FormatOverride> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings16.Charts.FormatOverride>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings16.Charts.FormatOverride>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings16.Charts.FormatOverrideImpl valImpl)
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
        if (val is DocumentModel.Drawings16.Charts.FormatOverrideImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>()
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
