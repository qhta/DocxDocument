using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using LightRig = DocumentFormat.OpenXml.Drawing.LightRig;
using Rotation = DocumentModel.Drawings.Rotation;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Light Rig.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  ///   Rig Preset
  /// </summary>
  public static LightRigKind? GetRig(LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<LightRigValues, LightRigKind>(openXmlElement?.Rig?.Value);
  }

  public static void SetRig(LightRig? openXmlElement, LightRigKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rig = EnumValueConverter.CreateEnumValue<LightRigValues, LightRigKind>(value);
  }

  /// <summary>
  ///   Direction
  /// </summary>
  public static LightRigDirectionKind? GetDirection(LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<LightRigDirectionValues, LightRigDirectionKind>(openXmlElement?.Direction?.Value);
  }

  public static void SetDirection(LightRig? openXmlElement, LightRigDirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = EnumValueConverter.CreateEnumValue<LightRigDirectionValues, LightRigDirectionKind>(value);
  }

  /// <summary>
  ///   Rotation.
  /// </summary>
  public static Rotation? GetRotation(LightRig? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
    if (itemElement != null)
      return RotationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRotation(LightRig? openXmlElement, Rotation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RotationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Rotation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LightRig? CreateModelElement(LightRig? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LightRig();
      value.Rig = GetRig(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LightRig? value)
    where OpenXmlElementType : LightRig, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRig(openXmlElement, value?.Rig);
      SetDirection(openXmlElement, value?.Direction);
      SetRotation(openXmlElement, value?.Rotation);
      return openXmlElement;
    }
    return default;
  }
}