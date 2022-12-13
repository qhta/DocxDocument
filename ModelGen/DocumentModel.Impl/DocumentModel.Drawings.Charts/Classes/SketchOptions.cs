namespace DocumentModel.Drawings.Charts;

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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
        return item != null;
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
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode();
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
        return item != null;
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
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
