namespace DocumentModel.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public class FillOverlayImpl: ModelElementImpl, FillOverlay
{
  public DocumentFormat.OpenXml.Drawing.FillOverlay? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FillOverlay?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FillOverlayImpl(): base() {}
  
  public FillOverlayImpl(DocumentFormat.OpenXml.Drawing.FillOverlay openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blend
  /// </summary>
  public BlendMode? Blend
  {
    get => (BlendMode?)OpenXmlElement?.Blend?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Blend = (DocumentFormat.OpenXml.Drawing.BlendModeValues?)value;
    }
  }
  
  /// <summary>
  /// NoFill.
  /// </summary>
  public Boolean? NoFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.NoFill();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public SolidFill? SolidFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public GradientFill? GradientFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public BlipFill? BlipFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public Boolean? GroupFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.GroupFill();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
