namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Pivot Format.
/// </summary>
public partial class PivotFormatImpl: ModelElementImpl, PivotFormat
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotFormat?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PivotFormatImpl(): base() {}
  
  public PivotFormatImpl(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Index != null)
        {
          if (value is not null)
            OpenXmlElement.Index.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Index = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Index = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.MarkerImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.MarkerImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabel? DataLabel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DataLabelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DataLabelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
