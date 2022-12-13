namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public class ColorStyleImpl: ModelElementImpl, ColorStyle
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorStyleImpl(): base() {}
  
  public ColorStyleImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Method
  {
    get => (System.String?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id
  {
    get => (System.UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Drawings13.Charts.ColorStyleVariation>? ColorStyleVariations
  {
    get
    {
      if (_ColorStyleVariations != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>()
            .Select(item => new DocumentModel.Drawings13.Charts.ColorStyleVariationImpl(item)).ToList();
          _ColorStyleVariations = new ObservableCollection<DocumentModel.Drawings13.Charts.ColorStyleVariation>(items);
        }
        else
          _ColorStyleVariations = new ObservableCollection<DocumentModel.Drawings13.Charts.ColorStyleVariation>();
        _ColorStyleVariations.CollectionChanged += _ColorStyleVariations_CollectionChanged;
      }
      return _ColorStyleVariations;
    }
    set
    {
      if (value != null && value != _ColorStyleVariations && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Drawings13.Charts.ColorStyleVariationImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings13.Charts.ColorStyleVariation> observableCollection)
        _ColorStyleVariations = observableCollection;
      else if (value != null)
        _ColorStyleVariations = new ObservableCollection<DocumentModel.Drawings13.Charts.ColorStyleVariation>(value);
      else
       _ColorStyleVariations = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings13.Charts.ColorStyleVariation>? _ColorStyleVariations;
  
  private void _ColorStyleVariations_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Drawings13.Charts.ColorStyleVariationImpl valImpl)
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
        if (val is DocumentModel.Drawings13.Charts.ColorStyleVariationImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>()
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
  
  
  public DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
