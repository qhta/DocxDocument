namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Copyrights Class.
/// </summary>
public partial class CopyrightsImpl: ModelElementImpl, Copyrights
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CopyrightsImpl(): base() {}
  
  public CopyrightsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<System.String>? CopyrightXsdstrings
  {
    get
    {
      if (_CopyrightXsdstrings != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>()
            .Select(item => item.Text).ToList();
          _CopyrightXsdstrings = new ObservableCollection<System.String>(items);
        }
        else
          _CopyrightXsdstrings = new ObservableCollection<System.String>();
        _CopyrightXsdstrings.CollectionChanged += _CopyrightXsdstrings_CollectionChanged;
      }
      return _CopyrightXsdstrings;
    }
    set
    {
      if (value != null && value != _CopyrightXsdstrings && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>();
        foreach (var val in value)
        {
          if (val is string str)
          {
            var item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring{ Text = str };
            OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<System.String> observableCollection)
        _CopyrightXsdstrings = observableCollection;
      else if (value != null)
        _CopyrightXsdstrings = new ObservableCollection<System.String>(value);
      else
       _CopyrightXsdstrings = null;
    }
  }
  private ObservableCollection<System.String>? _CopyrightXsdstrings;
  
  private void _CopyrightXsdstrings_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
          if (val is string str)
          {
            var newItem = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring { Text = str };
            OpenXmlElement.AddChild(newItem);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
        if (val is string str)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>()
                          .FirstOrDefault(anItem => anItem.Text == str);
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
