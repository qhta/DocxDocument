namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
public partial class View3DImpl: ModelElementImpl, View3D
{
  public DocumentFormat.OpenXml.Drawing.Charts.View3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.View3D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public View3DImpl(): base() {}
  
  public View3DImpl(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// X Rotation.
  /// </summary>
  public SByte? RotateX
  {
    get => (System.SByte?)OpenXmlElement?.RotateX?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RotateX != null)
        {
          if (value is not null)
            OpenXmlElement.RotateX.Val = (System.SByte?)value;
          else
            OpenXmlElement.RotateX = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RotateX = new DocumentFormat.OpenXml.Drawing.Charts.RotateX{ Val = (System.SByte?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  public UInt16? HeightPercent
  {
    get => (System.UInt16?)OpenXmlElement?.HeightPercent?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HeightPercent != null)
        {
          if (value is not null)
            OpenXmlElement.HeightPercent.Val = (System.UInt16?)value;
          else
            OpenXmlElement.HeightPercent = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HeightPercent = new DocumentFormat.OpenXml.Drawing.Charts.HeightPercent{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  public UInt16? RotateY
  {
    get => (System.UInt16?)OpenXmlElement?.RotateY?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RotateY != null)
        {
          if (value is not null)
            OpenXmlElement.RotateY.Val = (System.UInt16?)value;
          else
            OpenXmlElement.RotateY = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RotateY = new DocumentFormat.OpenXml.Drawing.Charts.RotateY{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  public UInt16? DepthPercent
  {
    get => (System.UInt16?)OpenXmlElement?.DepthPercent?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DepthPercent != null)
        {
          if (value is not null)
            OpenXmlElement.DepthPercent.Val = (System.UInt16?)value;
          else
            OpenXmlElement.DepthPercent = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DepthPercent = new DocumentFormat.OpenXml.Drawing.Charts.DepthPercent{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  public Boolean? RightAngleAxes
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  public Byte? Perspective
  {
    get => (System.Byte?)OpenXmlElement?.Perspective?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Perspective != null)
        {
          if (value is not null)
            OpenXmlElement.Perspective.Val = (System.Byte?)value;
          else
            OpenXmlElement.Perspective = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Perspective = new DocumentFormat.OpenXml.Drawing.Charts.Perspective{ Val = (System.Byte?)value };
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
