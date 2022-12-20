namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public partial class ManualLayoutImpl: ModelElementImpl, ManualLayout
{
  public DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ManualLayout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ManualLayoutImpl(): base() {}
  
  public ManualLayoutImpl(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Layout Target.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutTargetKind? LayoutTarget
  {
    get => (DocumentModel.Drawings.Charts.LayoutTargetKind?)OpenXmlElement?.LayoutTarget?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LayoutTarget != null)
        {
          if (value is not null)
            OpenXmlElement.LayoutTarget.Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues?)value;
          else
            OpenXmlElement.LayoutTarget = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LayoutTarget = new DocumentFormat.OpenXml.Drawing.Charts.LayoutTarget{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? LeftMode
  {
    get => (DocumentModel.Drawings.Charts.LayoutMode?)OpenXmlElement?.LeftMode?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LeftMode != null)
        {
          if (value is not null)
            OpenXmlElement.LeftMode.Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value;
          else
            OpenXmlElement.LeftMode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LeftMode = new DocumentFormat.OpenXml.Drawing.Charts.LeftMode{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? TopMode
  {
    get => (DocumentModel.Drawings.Charts.LayoutMode?)OpenXmlElement?.TopMode?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TopMode != null)
        {
          if (value is not null)
            OpenXmlElement.TopMode.Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value;
          else
            OpenXmlElement.TopMode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TopMode = new DocumentFormat.OpenXml.Drawing.Charts.TopMode{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? WidthMode
  {
    get => (DocumentModel.Drawings.Charts.LayoutMode?)OpenXmlElement?.WidthMode?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.WidthMode != null)
        {
          if (value is not null)
            OpenXmlElement.WidthMode.Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value;
          else
            OpenXmlElement.WidthMode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.WidthMode = new DocumentFormat.OpenXml.Drawing.Charts.WidthMode{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? HeightMode
  {
    get => (DocumentModel.Drawings.Charts.LayoutMode?)OpenXmlElement?.HeightMode?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HeightMode != null)
        {
          if (value is not null)
            OpenXmlElement.HeightMode.Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value;
          else
            OpenXmlElement.HeightMode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HeightMode = new DocumentFormat.OpenXml.Drawing.Charts.HeightMode{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  public Double? Left
  {
    get => (System.Double?)OpenXmlElement?.Left?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Left != null)
        {
          if (value is not null)
            OpenXmlElement.Left.Val = (System.Double?)value;
          else
            OpenXmlElement.Left = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Left = new DocumentFormat.OpenXml.Drawing.Charts.Left{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  public Double? Top
  {
    get => (System.Double?)OpenXmlElement?.Top?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Top != null)
        {
          if (value is not null)
            OpenXmlElement.Top.Val = (System.Double?)value;
          else
            OpenXmlElement.Top = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Top = new DocumentFormat.OpenXml.Drawing.Charts.Top{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  public Double? Width
  {
    get => (System.Double?)OpenXmlElement?.Width?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Width != null)
        {
          if (value is not null)
            OpenXmlElement.Width.Val = (System.Double?)value;
          else
            OpenXmlElement.Width = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Width = new DocumentFormat.OpenXml.Drawing.Charts.Width{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  public Double? Height
  {
    get => (System.Double?)OpenXmlElement?.Height?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Height != null)
        {
          if (value is not null)
            OpenXmlElement.Height.Val = (System.Double?)value;
          else
            OpenXmlElement.Height = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Height = new DocumentFormat.OpenXml.Drawing.Charts.Height{ Val = (System.Double?)value };
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
