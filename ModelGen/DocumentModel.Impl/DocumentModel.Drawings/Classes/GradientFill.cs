namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public class GradientFillImpl: ModelElementImpl, GradientFill
{
  public DocumentFormat.OpenXml.Drawing.GradientFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GradientFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GradientFillImpl(): base() {}
  
  public GradientFillImpl(DocumentFormat.OpenXml.Drawing.GradientFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Tile Flip
  /// </summary>
  public DocumentModel.Drawings.TileFlipKind? Flip
  {
    get => (DocumentModel.Drawings.TileFlipKind?)OpenXmlElement?.Flip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Flip = (DocumentFormat.OpenXml.Drawing.TileFlipValues?)value;
    }
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape
  {
    get => (System.Boolean?)OpenXmlElement?.RotateWithShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotateWithShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public DocumentModel.Drawings.GradientStopList? GradientStopList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStopList>();
        if (item != null)
          return new DocumentModel.Drawings.GradientStopListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStopList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GradientStopListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.LinearGradientFill? LinearGradientFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinearGradientFill>();
        if (item != null)
          return new DocumentModel.Drawings.LinearGradientFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinearGradientFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.LinearGradientFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.PathGradientFill? PathGradientFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathGradientFill>();
        if (item != null)
          return new DocumentModel.Drawings.PathGradientFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathGradientFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PathGradientFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.RelativeRectangleType? TileRectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeRectangleType>();
        if (item != null)
          return new DocumentModel.Drawings.RelativeRectangleTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeRectangleType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RelativeRectangleTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
