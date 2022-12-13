namespace DocumentModel.Math;

/// <summary>
/// Phantom Properties.
/// </summary>
public class PhantomPropertiesImpl: ModelElementImpl, PhantomProperties
{
  public DocumentFormat.OpenXml.Math.PhantomProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.PhantomProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PhantomPropertiesImpl(): base() {}
  
  public PhantomPropertiesImpl(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Phantom Show.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ShowPhantom
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.ShowPhantom?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ShowPhantom != null)
        {
          if (value is not null)
            OpenXmlElement.ShowPhantom.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.ShowPhantom = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ShowPhantom = new DocumentFormat.OpenXml.Math.ShowPhantom{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Phantom Zero Width.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ZeroWidth
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.ZeroWidth?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ZeroWidth != null)
        {
          if (value is not null)
            OpenXmlElement.ZeroWidth.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.ZeroWidth = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ZeroWidth = new DocumentFormat.OpenXml.Math.ZeroWidth{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Phantom Zero Ascent.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ZeroAscent
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.ZeroAscent?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ZeroAscent != null)
        {
          if (value is not null)
            OpenXmlElement.ZeroAscent.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.ZeroAscent = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ZeroAscent = new DocumentFormat.OpenXml.Math.ZeroAscent{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Phantom Zero Descent.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ZeroDescent
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.ZeroDescent?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ZeroDescent != null)
        {
          if (value is not null)
            OpenXmlElement.ZeroDescent.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.ZeroDescent = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ZeroDescent = new DocumentFormat.OpenXml.Math.ZeroDescent{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Transparent (Phantom).
  /// </summary>
  public DocumentModel.Math.BooleanKind? Transparent
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.Transparent?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Transparent != null)
        {
          if (value is not null)
            OpenXmlElement.Transparent.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.Transparent = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Transparent = new DocumentFormat.OpenXml.Math.Transparent{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
