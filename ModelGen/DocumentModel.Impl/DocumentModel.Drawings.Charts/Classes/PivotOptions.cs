namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public partial class PivotOptionsImpl: ModelElementImpl, PivotOptions
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PivotOptionsImpl(): base() {}
  
  public PivotOptionsImpl(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public Boolean? DropZoneFilter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public Boolean? DropZoneCategories
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public Boolean? DropZoneData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public Boolean? DropZoneSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public Boolean? DropZonesVisible
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
