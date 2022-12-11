namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public class PivotOptionsImpl: ModelElementImpl, PivotOptions
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter{ Val = (System.Boolean?)value };
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories{ Val = (System.Boolean?)value };
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData{ Val = (System.Boolean?)value };
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries{ Val = (System.Boolean?)value };
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
