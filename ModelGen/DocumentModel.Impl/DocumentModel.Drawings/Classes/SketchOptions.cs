namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public class SketchOptionsImpl: ModelElementImpl, SketchOptions
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SketchOptionsImpl(): base() {}
  
  public SketchOptionsImpl(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// InSketchMode.
  /// </summary>
  public Boolean? InSketchMode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
        return (Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
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
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  public Boolean? ShowSketchButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
        return (Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
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
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
