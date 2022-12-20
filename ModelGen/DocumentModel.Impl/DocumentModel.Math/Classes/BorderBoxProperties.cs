namespace DocumentModel.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public partial class BorderBoxPropertiesImpl: ModelElementImpl, BorderBoxProperties
{
  public DocumentFormat.OpenXml.Math.BorderBoxProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.BorderBoxProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BorderBoxPropertiesImpl(): base() {}
  
  public BorderBoxPropertiesImpl(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideTop
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideTop?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideTop != null)
        {
          if (value is not null)
            OpenXmlElement.HideTop.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideTop = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideTop = new DocumentFormat.OpenXml.Math.HideTop{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideBottom
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideBottom?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideBottom != null)
        {
          if (value is not null)
            OpenXmlElement.HideBottom.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideBottom = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideBottom = new DocumentFormat.OpenXml.Math.HideBottom{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideLeft
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideLeft?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideLeft != null)
        {
          if (value is not null)
            OpenXmlElement.HideLeft.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideLeft = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideLeft = new DocumentFormat.OpenXml.Math.HideLeft{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideRight
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideRight?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideRight != null)
        {
          if (value is not null)
            OpenXmlElement.HideRight.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideRight = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideRight = new DocumentFormat.OpenXml.Math.HideRight{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeHorizontal
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.StrikeHorizontal?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StrikeHorizontal != null)
        {
          if (value is not null)
            OpenXmlElement.StrikeHorizontal.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.StrikeHorizontal = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StrikeHorizontal = new DocumentFormat.OpenXml.Math.StrikeHorizontal{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeVertical
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.StrikeVertical?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StrikeVertical != null)
        {
          if (value is not null)
            OpenXmlElement.StrikeVertical.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.StrikeVertical = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StrikeVertical = new DocumentFormat.OpenXml.Math.StrikeVertical{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeBottomLeftToTopRight
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.StrikeBottomLeftToTopRight?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StrikeBottomLeftToTopRight != null)
        {
          if (value is not null)
            OpenXmlElement.StrikeBottomLeftToTopRight.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.StrikeBottomLeftToTopRight = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StrikeBottomLeftToTopRight = new DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeTopLeftToBottomRight
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.StrikeTopLeftToBottomRight?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StrikeTopLeftToBottomRight != null)
        {
          if (value is not null)
            OpenXmlElement.StrikeTopLeftToBottomRight.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.StrikeTopLeftToBottomRight = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StrikeTopLeftToBottomRight = new DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
