using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using LightRig = DocumentFormat.OpenXml.Office2010.Word.LightRig;
using SphereCoordinates = DocumentModel.Wordprocessing.SphereCoordinates;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the LightRig Class.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  ///   rig, this property is only available in Office 2010 and later.
  /// </summary>
  public static LightRigKind? GetLightRigType(LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<LightRigTypeValues, LightRigKind>(openXmlElement?.LightRigType?.Value);
  }

  public static void SetLightRigType(LightRig? openXmlElement, LightRigKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LightRigType = EnumValueConverter.CreateEnumValue<LightRigTypeValues, LightRigKind>(value);
  }

  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static LightRigDirectionKind? GetLightDirectionType(LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<LightRigDirectionValues, LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value);
  }

  public static void SetLightDirectionType(LightRig? openXmlElement, LightRigDirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LightDirectionType = EnumValueConverter.CreateEnumValue<LightRigDirectionValues, LightRigDirectionKind>(value);
  }

  /// <summary>
  ///   SphereCoordinates.
  /// </summary>
  public static SphereCoordinates? GetSphereCoordinates(LightRig? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates>();
    if (itemElement != null)
      return SphereCoordinatesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSphereCoordinates(LightRig? openXmlElement, SphereCoordinates? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SphereCoordinatesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.LightRig? CreateModelElement(LightRig? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LightRig();
      value.LightRigType = GetLightRigType(openXmlElement);
      value.LightDirectionType = GetLightDirectionType(openXmlElement);
      value.SphereCoordinates = GetSphereCoordinates(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LightRig? value)
    where OpenXmlElementType : LightRig, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLightRigType(openXmlElement, value?.LightRigType);
      SetLightDirectionType(openXmlElement, value?.LightDirectionType);
      SetSphereCoordinates(openXmlElement, value?.SphereCoordinates);
      return openXmlElement;
    }
    return default;
  }
}