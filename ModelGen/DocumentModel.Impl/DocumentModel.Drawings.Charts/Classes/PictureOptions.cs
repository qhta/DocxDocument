namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public class PictureOptionsImpl: ModelElementImpl, PictureOptions
{
  public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PictureOptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PictureOptionsImpl(): base() {}
  
  public PictureOptionsImpl(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public Boolean? ApplyToFront
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public Boolean? ApplyToSides
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public Boolean? ApplyToEnd
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureFormatKind? PictureFormat
  {
    get => (DocumentModel.Drawings.Charts.PictureFormatKind?)OpenXmlElement?.PictureFormat?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PictureFormat != null)
        {
          if (value is not null)
            OpenXmlElement.PictureFormat.Val = (DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues?)value;
          else
            OpenXmlElement.PictureFormat = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PictureFormat = new DocumentFormat.OpenXml.Drawing.Charts.PictureFormat{ Val = (DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit
  {
    get => (System.Double?)OpenXmlElement?.PictureStackUnit?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PictureStackUnit != null)
        {
          if (value is not null)
            OpenXmlElement.PictureStackUnit.Val = (System.Double?)value;
          else
            OpenXmlElement.PictureStackUnit = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PictureStackUnit = new DocumentFormat.OpenXml.Drawing.Charts.PictureStackUnit{ Val = (System.Double?)value };
        }
      }
    }
  }
  
}
