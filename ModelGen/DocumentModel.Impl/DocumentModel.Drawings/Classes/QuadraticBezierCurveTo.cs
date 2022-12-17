namespace DocumentModel.Drawings;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public class QuadraticBezierCurveToImpl: ModelElementImpl, QuadraticBezierCurveTo
{
  public DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public QuadraticBezierCurveToImpl(): base() {}
  
  public QuadraticBezierCurveToImpl(DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.AdjustPoint2DType>? Points
  {
    get
    {
      if (_Points != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Point>()
            .Select(item => new DocumentModel.Drawings.AdjustPoint2DTypeImpl(item)).ToList();
          _Points = new ObservableCollection<DocumentModel.Drawings.AdjustPoint2DType>(items);
        }
        else
          _Points = new ObservableCollection<DocumentModel.Drawings.AdjustPoint2DType>();
        _Points.CollectionChanged += _Points_CollectionChanged;
      }
      return _Points;
    }
    set
    {
      if (value != null && value != _Points && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Point>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.AdjustPoint2DTypeImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.AdjustPoint2DType> observableCollection)
        _Points = observableCollection;
      else if (value != null)
        _Points = new ObservableCollection<DocumentModel.Drawings.AdjustPoint2DType>(value);
      else
       _Points = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.AdjustPoint2DType>? _Points;
  
  private void _Points_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Point>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.AdjustPoint2DTypeImpl valImpl)
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
              if (val is DocumentModel.Drawings.AdjustPoint2DTypeImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Point>()
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
