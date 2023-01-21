namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Control Class.
/// </summary>
public static class ControlConverter
{
  /// <summary>
  /// Unique Name for Embedded Control
  /// </summary>
  private static String? GetName(DXW.Control openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXW.Control openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  private static String? GetShapeId(DXW.Control openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DXW.Control openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
  /// </summary>
  private static String? GetId(DXW.Control openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.Control openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.Control? CreateModelElement(DXW.Control? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Control();
      value.Name = GetName(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Control? value)
    where OpenXmlElementType: DXW.Control, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetShapeId(openXmlElement, value?.ShapeId);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
