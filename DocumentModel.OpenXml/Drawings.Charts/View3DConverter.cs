using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   3D view settings.
/// </summary>
public static class View3DConverter
{
  /// <summary>
  ///   X Rotation.
  /// </summary>
  public static SByte? GetRotateX(View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RotateX>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRotateX(View3D? openXmlElement, SByte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RotateX>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RotateX { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Height Percent.
  /// </summary>
  public static UInt16? GetHeightPercent(View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HeightPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHeightPercent(View3D? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HeightPercent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new HeightPercent { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Y Rotation.
  /// </summary>
  public static UInt16? GetRotateY(View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RotateY>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRotateY(View3D? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RotateY>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RotateY { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Depth Percent.
  /// </summary>
  public static UInt16? GetDepthPercent(View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DepthPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDepthPercent(View3D? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DepthPercent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DepthPercent { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Right Angle Axes.
  /// </summary>
  public static Boolean? GetRightAngleAxes(View3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightAngleAxes>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRightAngleAxes(View3D? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RightAngleAxes>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RightAngleAxes();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Perspective.
  /// </summary>
  public static Byte? GetPerspective(View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Perspective>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPerspective(View3D? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Perspective>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Perspective { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(View3D? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.View3D? CreateModelElement(View3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.View3D();
      value.RotateX = GetRotateX(openXmlElement);
      value.HeightPercent = GetHeightPercent(openXmlElement);
      value.RotateY = GetRotateY(openXmlElement);
      value.DepthPercent = GetDepthPercent(openXmlElement);
      value.RightAngleAxes = GetRightAngleAxes(openXmlElement);
      value.Perspective = GetPerspective(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.View3D? value)
    where OpenXmlElementType : View3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotateX(openXmlElement, value?.RotateX);
      SetHeightPercent(openXmlElement, value?.HeightPercent);
      SetRotateY(openXmlElement, value?.RotateY);
      SetDepthPercent(openXmlElement, value?.DepthPercent);
      SetRightAngleAxes(openXmlElement, value?.RightAngleAxes);
      SetPerspective(openXmlElement, value?.Perspective);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}