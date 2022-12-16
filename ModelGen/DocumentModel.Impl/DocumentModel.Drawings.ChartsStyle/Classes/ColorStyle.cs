namespace DocumentModel.Drawings.ChartsStyle;

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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
        if (item != null)
          return new DocumentModel.Drawings.RgbColorModelPercentageImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RgbColorModelPercentageImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
        if (item != null)
          return new DocumentModel.Drawings.RgbColorModelHexImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RgbColorModelHexImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.HslColor? HslColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
        if (item != null)
          return new DocumentModel.Drawings.HslColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HslColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.SystemColor? SystemColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
        if (item != null)
          return new DocumentModel.Drawings.SystemColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SystemColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
        if (item != null)
          return new DocumentModel.Drawings.SchemeColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SchemeColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.PresetColor? PresetColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
        if (item != null)
          return new DocumentModel.Drawings.PresetColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PresetColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>? ColorStyleVariations
  {
    get
    {
      if (_ColorStyleVariations != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>()
            .Select(item => new DocumentModel.Drawings.ChartsStyle.ColorStyleVariationImpl(item)).ToList();
          _ColorStyleVariations = new ObservableCollection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>(items);
        }
        else
          _ColorStyleVariations = new ObservableCollection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>();
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
        if (val is DocumentModel.Drawings.ChartsStyle.ColorStyleVariationImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation> observableCollection)
        _ColorStyleVariations = observableCollection;
      else if (value != null)
        _ColorStyleVariations = new ObservableCollection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>(value);
      else
       _ColorStyleVariations = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>? _ColorStyleVariations;
  
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
          if (val is DocumentModel.Drawings.ChartsStyle.ColorStyleVariationImpl valImpl)
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
        if (val is DocumentModel.Drawings.ChartsStyle.ColorStyleVariationImpl valImpl)
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
  
  
  public DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
