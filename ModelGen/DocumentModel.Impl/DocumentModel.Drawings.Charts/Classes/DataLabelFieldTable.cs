namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public partial class DataLabelFieldTableImpl: ModelElementImpl, DataLabelFieldTable
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DataLabelFieldTableImpl(): base() {}
  
  public DataLabelFieldTableImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>? DataLabelFieldTableEntries
  {
    get
    {
      if (_DataLabelFieldTableEntries == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>()
            .Select(item => new DocumentModel.Drawings.Charts.DataLabelFieldTableEntryImpl(item)).ToList();
          _DataLabelFieldTableEntries = new ObservableCollection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>(items);
        }
        else
          _DataLabelFieldTableEntries = new ObservableCollection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>();
        _DataLabelFieldTableEntries.CollectionChanged += _DataLabelFieldTableEntries_CollectionChanged;
      }
      return _DataLabelFieldTableEntries;
    }
    set
    {
      if (value != null && value != _DataLabelFieldTableEntries && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Charts.DataLabelFieldTableEntryImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry> observableCollection)
        _DataLabelFieldTableEntries = observableCollection;
      else if (value != null)
        _DataLabelFieldTableEntries = new ObservableCollection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>(value);
      else
       _DataLabelFieldTableEntries = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>? _DataLabelFieldTableEntries;
  
  private void _DataLabelFieldTableEntries_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Charts.DataLabelFieldTableEntryImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Drawings.Charts.DataLabelFieldTableEntryImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>()
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
